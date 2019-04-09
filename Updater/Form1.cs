using Devart.Data.Oracle;
//using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    //logList.Invoke(new Action(() => { logList.Items.Add($"[DEBUG] 3"); }));
    public partial class Form1 : Form
    {
        public bool IsRemoteServerPinging = false;
        public bool IsPackageExists = false;
        Task task;

        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        CancellationToken token = cancelTokenSource.Token;

        delegate void Message(string str, ListView lb);
        static private void InvokeMessage(string str, ListView lb)
        {
            lb.Invoke(new Action(() => { lb.Items.Add(str); }));
        }
        Message msg = InvokeMessage;

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                OracleDbService.Configure();
                LoadSettings();
                RefreshServiceData();
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}"); }
        }


        // основной функционал для обновлений



        bool DownloadUpdate(List<string> listUpd = null, bool OutputEnabled = true)
        {
            var action = "download";
            try
            {
                List<string> upd = listUpd == null ? GetUpdateElementsList() : listUpd;

                if (upd == null || upd.Count <= 0)
                {
                    SetControlsEnabling(true);
                    MessageBox.Show(null, $"Необходимо выделить хотябы один элемент из списка слева чтобы скачать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if(OutputEnabled)logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] НАЧАТО СКАЧИВАНИЕ ОБНОВЛЕНИЯ"); }));
                string signature = UpdateStart(action, OutputEnabled);
                if (OutputEnabled)
                    statusStrip1.Invoke( new Action( () => { progressBar.Maximum = upd.Count; } ) );

                for (int i = 0; i <= upd.Count - 1; ++i)
                {
                    Download(signature, upd[i], action, OutputEnabled);
                }

                UpdateEnd(signature, action, OutputEnabled);
                if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] СКАЧИВАНИЕ ОБНОВЛЕНИЯ ЗАВЕРШЕНО"); }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlsEnabling(true);
                return false;
            }

            return true;
        }

        bool ProcessUpdate(List<string> listUpd = null, bool OutputEnabled = true)
        {
            var action = "process";
            try
            {
                List<string> upd = listUpd == null ? GetUpdateElementsList() : listUpd;

                if (upd == null || upd.Count <= 0)
                {
                    SetControlsEnabling(true);
                    MessageBox.Show(null, $"Необходимо выделить хотябы один элемент из списка слева чтобы обработать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] НАЧАТА ОБРАБОТКА ОБНОВЛЕНИЯ"); }));
                string signature = UpdateStart(action, OutputEnabled);
                if (OutputEnabled)
                    statusStrip1.Invoke( new Action( () => { progressBar.Maximum = upd.Count; } ) );

                for (int i = 0; i <= upd.Count - 1; ++i)
                {
                    Process(signature, upd[i], action, OutputEnabled);
                }

                UpdateEnd(signature, action, OutputEnabled);
                if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] ОБРАБОТКА ОБНОВЛЕНИЯ ЗАВЕРШЕНА"); }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlsEnabling(true);
                return false;
            }
            return true;
        }


        string UpdateStart(string comment, bool OutputEnabled)
        {
            if (OutputEnabled)
                statusStrip1.Invoke( new Action( () => { progressBar.Value = 0; } ) );
            SetControlsEnabling(false);
            var start_time = OracleDateFormat(DateTime.Now);
            OracleDbService.ConnOpen();

            string SERVER_HOST = OracleDbService.SelectSingleValue($"SELECT SYS_CONTEXT('USERENV','SERVER_HOST') FROM dual");
            string signature = OracleDbService.SelectSingleValue($"SELECT '{SERVER_HOST}_'||to_char({start_time},'ddmmyyyy') FROM dual");
            int signature_count
                = int.Parse(OracleDbService.SelectSingleValue($@"SELECT count(*) FROM abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" where SIGNATURE='{signature}' and ""COMMENT""='{comment}'"));
            if (signature_count == 0)
            {
                OracleDbService.Insert($@"
insert into abt.update_log2@""{AppConfig.OracleRemoteLinkName}""
( SIGNATURE,UPDATE_START,""IP_ADDRESS"",""NETWORK_PROTOCOL"",""OS_USER"",""PROXY_USER"",""SESSION_USER"",""host"",""COMMENT"")
values
('{signature}'
, {start_time}
, '{OracleDbService.SelectSingleValue("SELECT SYS_CONTEXT('USERENV','IP_ADDRESS') FROM dual")}'
, '{OracleDbService.SelectSingleValue("SELECT SYS_CONTEXT('USERENV','NETWORK_PROTOCOL') FROM dual")}'
, '{OracleDbService.SelectSingleValue("SELECT SYS_CONTEXT('USERENV','OS_USER') FROM dual")}'
, '{OracleDbService.SelectSingleValue("SELECT SYS_CONTEXT('USERENV','PROXY_USER') FROM dual")}'
, '{OracleDbService.SelectSingleValue("SELECT SYS_CONTEXT('USERENV','SESSION_USER') FROM dual")}'
, '{SERVER_HOST}'
, '{comment}')");

            }

            OracleDbService.Insert($@"
UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" SET
  BAR_CODES = null
, CONTRACTORS = null
, COUNTRIES = null
, CUSTOMERS = null
, GOODS = null
, GROUPS = null
, GROUP_ITEMS = null
, ITEMS = null
, PRICES_CACHE = null
, UPDATE_START = {start_time}
, UPDATE_END = null
  WHERE SIGNATURE = '{signature}' and ""COMMENT""='{comment}'");

            return signature;
        }

        void UpdateEnd(string signature, string comment, bool OutputEnabled)
        {
            if (OutputEnabled)
                statusStrip1.Invoke( new Action( () => { progressBar.Value = 0; } ) );
            OracleDbService.Insert($@"UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" SET UPDATE_END = SYSDATE WHERE SIGNATURE = '{signature}' and ""COMMENT""='{comment}'");
            OracleDbService.conn.Close();
            if (OutputEnabled)
                statusStrip1.Invoke( new Action( () => { progressBar.Value = progressBar.Maximum; } ) );
            SetControlsEnabling(true);
        }


        void Download(string signature, string obj, string comment, bool OutputEnabled = true)
        {
            if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] {obj} скачивается..."); }));
            var start_time = DateTime.Now;
            List<OracleCommand> sqls = new List<OracleCommand>();
            sqls.Add(new OracleCommand()
            {
                CommandText = $@"UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" SET {obj}=0 WHERE SIGNATURE='{signature}' and ""COMMENT""='{comment}'",
            });
            sqls.Add(new OracleCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = $"ABT.PKG_UPDATE.{obj}"
            });
            OracleDbService.ExecuteCommand(sqls);
            sqls.Clear();
            var time = Math.Round((DateTime.Now - start_time).TotalDays * 24 * 60 * 60).ToString();
            sqls.Add(new OracleCommand()
            {
                CommandText = $@"UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" " +
                              $@"SET {obj}={time} WHERE SIGNATURE='{signature}' and ""COMMENT""='{comment}'",
            });
            OracleDbService.ExecuteCommand(sqls);
            if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}]{obj} скачалось за {time} сек"); }));
            if (OutputEnabled)
                statusStrip1.Invoke( new Action( () => { progressBar.Value += 1; } ) );
        }

        void Process(string signature, string obj, string comment,bool OutputEnabled)
        {
            if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}] {obj} обрабатывается..."); }));
            var start_time = DateTime.Now;
            List<OracleCommand> sqls = new List<OracleCommand>();
            sqls.Add(new OracleCommand()
            {
                CommandText = $@"UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" SET {obj}=0 WHERE SIGNATURE='{signature}' and ""COMMENT""='{comment}'",
            });
            sqls.Add(new OracleCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = $"ABT.ABT_REPLICATION.PROCESS_" + (obj == "PRICES_CACHE" ? "PRICES" : obj)
            });
            OracleDbService.ExecuteCommand(sqls);

            sqls.Clear();
            var time = Math.Round((DateTime.Now - start_time).TotalDays * 24 * 60 * 60).ToString();
            sqls.Add(new OracleCommand()
            {
                CommandText = $@"UPDATE abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" " +
                              $@"SET {obj}={time} WHERE SIGNATURE='{signature}' and ""COMMENT""='{comment}'",
            });
            OracleDbService.ExecuteCommand(sqls);
            if (OutputEnabled) logList.Invoke(new Action(() => { logList.Items.Add($"[{DateFormat(DateTime.Now)}]{obj} обработано на {signature} за {time} сек"); }));
            if (OutputEnabled)
                statusStrip1.Invoke( new Action( () => { progressBar.Value += 1; } ) );
        }



        // вспомогательные функции



        void SaveSettings()
        {
            AppConfig.OracleRemoteUser = remoteUserTextBox.Text;
            AppConfig.OracleRemotePassword = remotePasswordTextBox.Text;
            AppConfig.OracleRemoteHost = remoteHostTextBox.Text;
            AppConfig.OracleRemotePort = remotePortTextBox.Text;
            AppConfig.OracleRemoteSID = remoteSidTextBox.Text;

            AppConfig.OracleLocalUser = localUserTextBox.Text;
            AppConfig.OracleLocalPassword = localPasswordTextBox.Text;
            AppConfig.OracleLocalHost = localHostTextBox.Text;
            AppConfig.OracleLocalSID = localSidTextBox.Text;
            AppConfig.OracleLocalPort = localPortTextBox.Text;

            AppConfig.OracleRemoteLinkName = remoteLinkName.Text;

        }

        void LoadSettings()
        {
            remoteUserTextBox.Text = AppConfig.OracleRemoteUser;
            remotePasswordTextBox.Text = AppConfig.OracleRemotePassword;
            remoteHostTextBox.Text = AppConfig.OracleRemoteHost;
            remotePortTextBox.Text = AppConfig.OracleRemotePort;
            remoteSidTextBox.Text = AppConfig.OracleRemoteSID;

            localUserTextBox.Text = AppConfig.OracleLocalUser;
            localPasswordTextBox.Text = AppConfig.OracleLocalPassword;
            localHostTextBox.Text = AppConfig.OracleLocalHost;
            localSidTextBox.Text = AppConfig.OracleLocalSID;
            localPortTextBox.Text = AppConfig.OracleLocalPort;

            remoteLinkName.Text = AppConfig.OracleRemoteLinkName;
        }

        void RefreshServiceData()
        {
            try
            {
                pingLabel.Text = "";
                packetLabel.Text = "";
                dbVersionLabel.Text = "";
                linkNameLabel.Text = "";
                storeIdLabel.Text = "";
                lastUpdateLabel.Text = "";

                if (Utilites.PingHost(AppConfig.OracleRemoteHost))
                {
                    pingLabel.Text = "доступно";
                    IsRemoteServerPinging = true;
                }
                else
                {
                    pingLabel.Text = "НЕТ СИГНАЛА";
                    IsRemoteServerPinging = false;
                }
                Task.Factory.StartNew(() =>
                {
                    OracleDbService.ConnOpen();
                    var dbVersion = OracleDbService.SelectSingleValue("SELECT SUBSTR(banner,6,10) FROM v$version WHERE BANNER LIKE 'CORE%'");
                    statusStrip1.Invoke(new Action(() => dbVersionLabel.Text = dbVersion));
                    var packet = OracleDbService.SelectSingleValue("SELECT object_name FROM all_objects WHERE object_type like 'PACKAGE' AND object_name like '%PKG_UPDATE%'");
                    statusStrip1.Invoke(new Action(() => packetLabel.Text = packet));
                    var storeId = OracleDbService.SelectSingleValue($"SELECT NAME FROM REF_STORES WHERE SORTID=999 AND OLDID=0");
                    statusStrip1.Invoke(new Action(() => storeIdLabel.Text = storeId));
                    var linkUser = OracleDbService.SelectSingleValue($"SELECT USERNAME from ALL_DB_LINKS WHERE db_link LIKE '%{AppConfig.OracleRemoteLinkName}%'");
                    var linkName = OracleDbService.SelectSingleValue($"SELECT DB_LINK from ALL_DB_LINKS WHERE db_link LIKE '%{AppConfig.OracleRemoteLinkName}%'");
                    statusStrip1.Invoke(new Action(() => linkNameLabel.Text = $"{linkName} ({linkUser})"));
                    var lastUpdate = OracleDbService.SelectSingleValue($@"SELECT MAX(UPDATE_END) FROM abt.update_log2@""{AppConfig.OracleRemoteLinkName}"" WHERE SIGNATURE LIKE SYS_CONTEXT('USERENV','SERVER_HOST')|| '%'");
                    statusStrip1.Invoke(new Action(() => lastUpdateLabel.Text = lastUpdate));
                    var checkLink = OracleDbService.SelectSingleValue($@"SELECT * FROM dual@""{AppConfig.OracleRemoteLinkName}""");
                    statusStrip1.Invoke(new Action(() => checkLinkLabel.Text = checkLink == "X" ? "работает" : "не работает"));

                    OracleDbService.conn.Close();

                    IsPackageExists = packetLabel.Text == "" ? false : true;
                    SetControlsEnabling(IsPackageExists && IsRemoteServerPinging);
                    //fullUpdateButton.Invoke(new Action(() => fullUpdateButton.Enabled = IsPackageExists && IsRemoteServerPinging));

                });
            }
            catch (Exception ex) { }
        }

        void SetControlsEnabling(bool enabled)
        {
            menuStrip1.Invoke(new Action(() => { обновитьToolStripMenuItem.Enabled = enabled; }));
            menuStrip1.Invoke(new Action(() => { скачатьToolStripMenuItem.Enabled = enabled; }));
            menuStrip1.Invoke(new Action(() => { обработатьToolStripMenuItem.Enabled = enabled; }));

            countriesCheckBox.Invoke(new Action(() => { countriesCheckBox.Enabled = enabled; }));
            customersCheckBox.Invoke(new Action(() => { customersCheckBox.Enabled = enabled; }));
            contractorsCheckBox.Invoke(new Action(() => { contractorsCheckBox.Enabled = enabled; }));
            groupsCheckBox.Invoke(new Action(() => { groupsCheckBox.Enabled = enabled; }));
            goodsCheckBox.Invoke(new Action(() => { goodsCheckBox.Enabled = enabled; }));
            group_itemsCheckBox.Invoke(new Action(() => { group_itemsCheckBox.Enabled = enabled; }));
            itemsCheckBox.Invoke(new Action(() => { itemsCheckBox.Enabled = enabled; }));
            prices_cacheCheckBox.Invoke(new Action(() => { prices_cacheCheckBox.Enabled = enabled; }));
            bar_codesCheckBox.Invoke(new Action(() => { bar_codesCheckBox.Enabled = enabled; }));
        }

        List<string> GetUpdateElementsList()
        {
            var upd = new List<string>();

            if (countriesCheckBox.Checked) upd.Add("COUNTRIES");
            if (customersCheckBox.Checked) upd.Add("CUSTOMERS");
            if (contractorsCheckBox.Checked) upd.Add("CONTRACTORS");
            if (groupsCheckBox.Checked) upd.Add("GROUPS");
            if (goodsCheckBox.Checked) upd.Add("GOODS");
            if (group_itemsCheckBox.Checked) upd.Add("GROUP_ITEMS");
            if (itemsCheckBox.Checked) upd.Add("ITEMS");
            if (prices_cacheCheckBox.Checked) upd.Add("PRICES_CACHE");
            if (bar_codesCheckBox.Checked) upd.Add("BAR_CODES");

            return upd;
        }

        string OracleDateFormat(DateTime Date) => $"TO_DATE('{Date.Day}/{Date.Month}/{Date.Year} {Date.Hour}:{Date.Minute}:{Date.Second}','DD/MM/YYYY hh24:mi:ss')";

        string DateFormat(DateTime Date) => $"{Date.Day}/{Date.Month}/{Date.Year} {Date.Hour}:{Date.Minute}:{Date.Second}:{Date.Millisecond}";

        public void installLink()
        {
            OracleDbService.ConnOpen();
            OracleDbService.ExecuteCommand(new OracleCommand()
            {
                CommandText = $@"CREATE PUBLIC DATABASE LINK ""{AppConfig.OracleRemoteLinkName}""
CONNECT TO {AppConfig.OracleRemoteUser} IDENTIFIED BY ""{AppConfig.OracleRemotePassword}"" USING '{AppConfig.OracleRemoteLinkTNS}'"
            });
            OracleDbService.conn.Close();
        }

        public void installPkg()
        {
            var SPECIFICATION =
                    "CREATE OR REPLACE PACKAGE ABT.pkg_update IS \n" +
                    "\tPROCEDURE BAR_CODES; \n" +
                    "\tPROCEDURE CONTRACTORS; \n" +
                    "\tPROCEDURE COUNTRIES; \n" +
                    "\tPROCEDURE CUSTOMERS; \n" +
                    "\tPROCEDURE GOODS; \n" +
                    "\tPROCEDURE GROUPS; \n" +
                    "\tPROCEDURE GROUP_ITEMS; \n" +
                    "\tPROCEDURE ITEMS; \n" +
                    "\tPROCEDURE PRICES_CACHE; \n" +
                    "END pkg_update; \n";

            var BODY = "CREATE OR REPLACE PACKAGE BODY pkg_update IS \n" +
"PROCEDURE BAR_CODES IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_BAR_CODES;\n" +
$"	INSERT INTO ABT.IMPORT_BAR_CODES SELECT * FROM ABT.UPDATE_BAR_CODES@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END BAR_CODES;\n" +
"PROCEDURE CONTRACTORS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_CONTRACTORS;\n" +
$"	INSERT INTO ABT.IMPORT_CONTRACTORS SELECT * FROM ABT.UPDATE_CONTRACTORS@\"{AppConfig.OracleRemoteLinkName}\" WHERE ID_DISTRICT IN (SELECT ID FROM REF_DISTRICTS RD); COMMIT;\n" +
"END CONTRACTORS;\n" +
"PROCEDURE COUNTRIES IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_COUNTRIES;\n" +
$"	INSERT INTO ABT.IMPORT_COUNTRIES SELECT * FROM ABT.UPDATE_COUNTRIES@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END COUNTRIES;\n" +
"PROCEDURE CUSTOMERS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_CUSTOMERS;\n" +
$"	INSERT INTO ABT.IMPORT_CUSTOMERS SELECT * FROM ABT.UPDATE_CUSTOMERS@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END CUSTOMERS;\n" +
"PROCEDURE GOODS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_GOODS;\n" +
$"	INSERT INTO ABT.IMPORT_GOODS SELECT * FROM ABT.UPDATE_GOODS@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END GOODS;\n" +
"PROCEDURE GROUPS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_GROUPS;\n" +
$"	INSERT INTO ABT.IMPORT_GROUPS SELECT * FROM ABT.UPDATE_GROUPS@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END GROUPS;\n" +
"PROCEDURE GROUP_ITEMS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_GROUP_ITEMS;\n" +
$"	INSERT INTO ABT.IMPORT_GROUP_ITEMS SELECT * FROM ABT.UPDATE_GROUP_ITEMS@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END GROUP_ITEMS;\n" +
"PROCEDURE ITEMS IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_ITEMS;\n" +
$"	INSERT INTO ABT.IMPORT_ITEMS SELECT * FROM ABT.UPDATE_ITEMS@\"{AppConfig.OracleRemoteLinkName}\"; COMMIT;\n" +
"END ITEMS;\n" +
"PROCEDURE PRICES_CACHE IS BEGIN\n" +
"	DELETE FROM ABT.IMPORT_PRICES_CACHE;\n" +
$"	INSERT INTO ABT.IMPORT_PRICES_CACHE SELECT * FROM ABT.UPDATE_PRICES_CACHE@\"{AppConfig.OracleRemoteLinkName}\" WHERE ID_PRICE_TYPE IN (SELECT ID FROM REF_PRICE_TYPES); COMMIT;" +
"END PRICES_CACHE;\n" +
"END pkg_update;";

            var sqls = new List<OracleCommand>();
            sqls.Add(new OracleCommand() { CommandText = SPECIFICATION, CommandType = CommandType.Text });
            sqls.Add(new OracleCommand() { CommandText = BODY, CommandType = CommandType.Text });

            OracleDbService.ConnOpen();
            OracleDbService.ExecuteCommand(sqls);
            OracleDbService.conn.Close();
        }

        public string InstallUpdate(string host)
        {
            if (host.Contains("\r")) host = host.TrimEnd('\r');
            if (host.Contains("\n")) host = host.TrimEnd('\n');
            if (String.IsNullOrEmpty(host)) return " host empty";
            if (!Utilites.PingHost(host)) return " ping";
            AppConfig.OracleLocalHost = host;
            OracleDbService.Configure();
            var cou = new List<string>() { "COUNTRIES" };
            string linkName = "", linkUser = "", checkLink = "", packet = "";
            OracleDbService.conn.Open();
            linkName = OracleDbService.SelectSingleValue($"SELECT DB_LINK from ALL_DB_LINKS WHERE db_link LIKE '%{AppConfig.OracleRemoteLinkName}%'");
            linkUser = OracleDbService.SelectSingleValue($"SELECT USERNAME from ALL_DB_LINKS WHERE db_link LIKE '%{AppConfig.OracleRemoteLinkName}%'");

            if (string.IsNullOrEmpty(linkName) || string.IsNullOrEmpty(linkUser)/* || linkUser != AppConfig.OracleRemoteUser*/)
            {
                try
                {
                    installLink();
                }
                catch (Exception ex)
                {
                    OracleDbService.conn.Close();
                    MessageBox.Show(" link install: " + ex.Message);
                    return " link install: " + ex.Message;
                }

                try
                {
                    checkLink = OracleDbService.SelectSingleValue($@"SELECT * FROM dual@""{AppConfig.OracleRemoteLinkName}""");
                }
                catch (Exception ex)
                {
                    OracleDbService.conn.Close();
                    MessageBox.Show(" link check: " + ex.Message);
                    return " link check: " + ex.Message;
                }

                if (string.IsNullOrEmpty(checkLink))
                {
                    OracleDbService.conn.Close();
                    return " link check";
                }
            }

            packet = OracleDbService.SelectSingleValue("SELECT object_name FROM all_objects WHERE object_type like 'PACKAGE' AND object_name like '%PKG_UPDATE%'");
            if (string.IsNullOrEmpty(packet))
            {
                installPkg();
            }
            try
            {
                if (DownloadUpdate(cou, false) && ProcessUpdate(cou, false))
                {
                    OracleDbService.conn.Close();
                    return "";
                }
                else
                {
                    OracleDbService.conn.Close();
                    return " down||proc";
                }
            }
            catch (Exception ex)
            {
                OracleDbService.conn.Close();
                return " link check: " + ex.Message;
            }
            return "";

        }


        // обработчики элементов формы
        
        private void button1_Click(object sender, EventArgs e)// кнопка обновления таблицы с бд обновлений
        {
            Task.Factory.StartNew(() =>
            {
                button1.Invoke(new Action(() => button1.Enabled = false));
                var log_conn = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.100.3)(PORT = 1521))(CONNECT_DATA = "
                            + $"(SERVER = DEDICATED)(SERVICE_NAME = XE)));User ID=abt;Password=tujybrnjytpyftn");
                DataTable dt = new DataTable();
                OracleDataAdapter adapter;
                OracleCommandBuilder builder;
                log_conn.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = log_conn;
                    adapter = new OracleDataAdapter(Utilites.GetLogSql(), log_conn);
                    builder = new OracleCommandBuilder(adapter);
                    log_conn.Close();
                }
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = dt));
                button1.Invoke(new Action(() => button1.Enabled = true));
            });
        }
        
        private void localHostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals( Keys.Enter ) && !String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                SaveSettings();
            }
        }












        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilites.PingHost( AppConfig.OracleRemoteHost ))
            {
                MessageBox.Show( "Сервер обновлений не доступен" );
                return;
            }
            task = Task.Factory.StartNew( () =>
            {
                if (DownloadUpdate() && ProcessUpdate())
                    MessageBox.Show( null, "Можете продолжить работу", "Обновление завершено!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            },
            token );
        }

        private void скачатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilites.PingHost( AppConfig.OracleRemoteHost ))
            {
                MessageBox.Show( "Сервер обновлений не доступен" );
                return;
            }
            task = Task.Factory.StartNew( () =>
            {
                if (DownloadUpdate())
                    MessageBox.Show( null, "Можете продолжить работу", "Обновление завершено!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }, token );
        }

        private void обработатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilites.PingHost( AppConfig.OracleRemoteHost ))
            {
                MessageBox.Show( "Сервер обновлений не доступен" );
                return;
            }
            task = Task.Factory.StartNew( () =>
            {
                if (ProcessUpdate())
                    MessageBox.Show( null, "Можете продолжить работу", "Обновление завершено!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }, token );
        }

        private void установитьПакетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            installPkg();
            RefreshServiceData();
        }

        private void установитьЛинкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                installLink();
            }
            catch (Exception ex) { MessageBox.Show( $"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}" ); }
            RefreshServiceData();
        }

        private void удалитьПакетToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                var sqls = new List<OracleCommand>();
                sqls.Add( new OracleCommand() { CommandText = "DROP PACKAGE BODY PKG_UPDATE" } );
                sqls.Add( new OracleCommand() { CommandText = "DROP PACKAGE PKG_UPDATE" } );
                OracleDbService.ConnOpen();
                OracleDbService.ExecuteCommand( sqls );
                OracleDbService.conn.Close();

            }
            catch (Exception ex) { MessageBox.Show( $"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}" ); }
            RefreshServiceData();
        }

        private void удалитьЛинкToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OracleDbService.ConnOpen();
                OracleDbService.ExecuteCommand( new OracleCommand()
                {
                    CommandText = $@"DROP PUBLIC DATABASE LINK  ""{AppConfig.OracleRemoteLinkName}"""
                } );
                OracleDbService.conn.Close();

            }
            catch (Exception ex) { MessageBox.Show( $"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.Source}\n\n{ex.TargetSite}" ); }
            RefreshServiceData();
        }

        private void списокХостовДляМассовогоОбновленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Text = "Список ip/host(1 на строку)";
            form2.Show();
        }

        private void начатьМассовоеОбновлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Task.Factory.StartNew( () =>
            {
                string resp = "";
                var failed = new List<string>();
                int c = Proxy.list.Count, f = 0, i = 0;
                foreach (var item in Proxy.list)
                {
                    i++;
                    msg( $"{i} из {c} {item}", logList );
                    resp = InstallUpdate( item );
                    if (resp != "")
                    {
                        failed.Add( $"ОШИБКА ЭЛЕМЕНТА #{c}: {item}{resp}" );
                        f++;
                    }
                    else
                        msg( $"БЕЗ ОШИБОК #{c}: {item}", logList );
                }
                msg( $"{f} из {c} с ошибками", logList );
            } );
        }

        private void сохранитьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьНастройкиToolStripMenuItem.Enabled = false;
            SaveSettings();
            OracleDbService.Configure();
            RefreshServiceData();
            сохранитьНастройкиToolStripMenuItem.Enabled = true;
        }

        private void автоматическаяУстановкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
