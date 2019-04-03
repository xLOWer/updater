namespace Updater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.bar_codesCheckBox = new System.Windows.Forms.CheckBox();
            this.prices_cacheCheckBox = new System.Windows.Forms.CheckBox();
            this.itemsCheckBox = new System.Windows.Forms.CheckBox();
            this.group_itemsCheckBox = new System.Windows.Forms.CheckBox();
            this.countriesCheckBox = new System.Windows.Forms.CheckBox();
            this.customersCheckBox = new System.Windows.Forms.CheckBox();
            this.contractorsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupsCheckBox = new System.Windows.Forms.CheckBox();
            this.goodsCheckBox = new System.Windows.Forms.CheckBox();
            this.processButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.fullUpdateButton = new System.Windows.Forms.Button();
            this.updateCancel = new System.Windows.Forms.Button();
            this.logList = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.optionsTabPage = new System.Windows.Forms.TabPage();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.resetSettingsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteLinkButton = new System.Windows.Forms.Button();
            this.deletePackcageButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkLinkLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lastUpdateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.storeIdLabel = new System.Windows.Forms.Label();
            this.Склад = new System.Windows.Forms.Label();
            this.linkNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dbVersionLabel = new System.Windows.Forms.Label();
            this.packetLabel = new System.Windows.Forms.Label();
            this.pingLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.installLinkButton = new System.Windows.Forms.Button();
            this.installPackageButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.remoteLinkName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.remotePasswordTextBox = new System.Windows.Forms.TextBox();
            this.remoteUserTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.remoteHostTextBox = new System.Windows.Forms.TextBox();
            this.remoteSidTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.remotePortTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.localUserTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.localPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.localHostTextBox = new System.Windows.Forms.TextBox();
            this.localSidTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.localPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.massUpdateButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.optionsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTabPage);
            this.tabControl1.Controls.Add(this.optionsTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.bar_codesCheckBox);
            this.mainTabPage.Controls.Add(this.prices_cacheCheckBox);
            this.mainTabPage.Controls.Add(this.itemsCheckBox);
            this.mainTabPage.Controls.Add(this.group_itemsCheckBox);
            this.mainTabPage.Controls.Add(this.countriesCheckBox);
            this.mainTabPage.Controls.Add(this.customersCheckBox);
            this.mainTabPage.Controls.Add(this.contractorsCheckBox);
            this.mainTabPage.Controls.Add(this.groupsCheckBox);
            this.mainTabPage.Controls.Add(this.goodsCheckBox);
            this.mainTabPage.Controls.Add(this.processButton);
            this.mainTabPage.Controls.Add(this.downloadButton);
            this.mainTabPage.Controls.Add(this.fullUpdateButton);
            this.mainTabPage.Controls.Add(this.updateCancel);
            this.mainTabPage.Controls.Add(this.logList);
            this.mainTabPage.Controls.Add(this.progressBar);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(813, 350);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Главная";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // bar_codesCheckBox
            // 
            this.bar_codesCheckBox.AutoSize = true;
            this.bar_codesCheckBox.Location = new System.Drawing.Point(3, 315);
            this.bar_codesCheckBox.Name = "bar_codesCheckBox";
            this.bar_codesCheckBox.Size = new System.Drawing.Size(91, 17);
            this.bar_codesCheckBox.TabIndex = 29;
            this.bar_codesCheckBox.Text = "BAR_CODES";
            this.bar_codesCheckBox.UseVisualStyleBackColor = true;
            // 
            // prices_cacheCheckBox
            // 
            this.prices_cacheCheckBox.AutoSize = true;
            this.prices_cacheCheckBox.Location = new System.Drawing.Point(3, 292);
            this.prices_cacheCheckBox.Name = "prices_cacheCheckBox";
            this.prices_cacheCheckBox.Size = new System.Drawing.Size(107, 17);
            this.prices_cacheCheckBox.TabIndex = 28;
            this.prices_cacheCheckBox.Text = "PRICES_CACHE";
            this.prices_cacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemsCheckBox
            // 
            this.itemsCheckBox.AutoSize = true;
            this.itemsCheckBox.Location = new System.Drawing.Point(3, 269);
            this.itemsCheckBox.Name = "itemsCheckBox";
            this.itemsCheckBox.Size = new System.Drawing.Size(59, 17);
            this.itemsCheckBox.TabIndex = 27;
            this.itemsCheckBox.Text = "ITEMS";
            this.itemsCheckBox.UseVisualStyleBackColor = true;
            // 
            // group_itemsCheckBox
            // 
            this.group_itemsCheckBox.AutoSize = true;
            this.group_itemsCheckBox.Location = new System.Drawing.Point(3, 246);
            this.group_itemsCheckBox.Name = "group_itemsCheckBox";
            this.group_itemsCheckBox.Size = new System.Drawing.Size(104, 17);
            this.group_itemsCheckBox.TabIndex = 26;
            this.group_itemsCheckBox.Text = "GROUP_ITEMS";
            this.group_itemsCheckBox.UseVisualStyleBackColor = true;
            // 
            // countriesCheckBox
            // 
            this.countriesCheckBox.AutoSize = true;
            this.countriesCheckBox.Location = new System.Drawing.Point(3, 223);
            this.countriesCheckBox.Name = "countriesCheckBox";
            this.countriesCheckBox.Size = new System.Drawing.Size(89, 17);
            this.countriesCheckBox.TabIndex = 25;
            this.countriesCheckBox.Text = "COUNTRIES";
            this.countriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // customersCheckBox
            // 
            this.customersCheckBox.AutoSize = true;
            this.customersCheckBox.Location = new System.Drawing.Point(3, 200);
            this.customersCheckBox.Name = "customersCheckBox";
            this.customersCheckBox.Size = new System.Drawing.Size(94, 17);
            this.customersCheckBox.TabIndex = 24;
            this.customersCheckBox.Text = "CUSTOMERS";
            this.customersCheckBox.UseVisualStyleBackColor = true;
            // 
            // contractorsCheckBox
            // 
            this.contractorsCheckBox.AutoSize = true;
            this.contractorsCheckBox.Location = new System.Drawing.Point(3, 177);
            this.contractorsCheckBox.Name = "contractorsCheckBox";
            this.contractorsCheckBox.Size = new System.Drawing.Size(108, 17);
            this.contractorsCheckBox.TabIndex = 23;
            this.contractorsCheckBox.Text = "CONTRACTORS";
            this.contractorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupsCheckBox
            // 
            this.groupsCheckBox.AutoSize = true;
            this.groupsCheckBox.Location = new System.Drawing.Point(3, 154);
            this.groupsCheckBox.Name = "groupsCheckBox";
            this.groupsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.groupsCheckBox.TabIndex = 22;
            this.groupsCheckBox.Text = "GROUPS";
            this.groupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // goodsCheckBox
            // 
            this.goodsCheckBox.AutoSize = true;
            this.goodsCheckBox.Location = new System.Drawing.Point(3, 131);
            this.goodsCheckBox.Name = "goodsCheckBox";
            this.goodsCheckBox.Size = new System.Drawing.Size(65, 17);
            this.goodsCheckBox.TabIndex = 21;
            this.goodsCheckBox.Text = "GOODS";
            this.goodsCheckBox.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processButton.Location = new System.Drawing.Point(3, 97);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(138, 28);
            this.processButton.TabIndex = 20;
            this.processButton.Text = "ОБРАБОТАТЬ";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.Location = new System.Drawing.Point(3, 63);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(138, 28);
            this.downloadButton.TabIndex = 19;
            this.downloadButton.Text = "СКАЧАТЬ";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // fullUpdateButton
            // 
            this.fullUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullUpdateButton.Location = new System.Drawing.Point(3, 6);
            this.fullUpdateButton.Name = "fullUpdateButton";
            this.fullUpdateButton.Size = new System.Drawing.Size(138, 33);
            this.fullUpdateButton.TabIndex = 8;
            this.fullUpdateButton.Text = "ОБНОВИТЬ";
            this.fullUpdateButton.UseVisualStyleBackColor = true;
            this.fullUpdateButton.Click += new System.EventHandler(this.fullUpdateButton_Click);
            // 
            // updateCancel
            // 
            this.updateCancel.Location = new System.Drawing.Point(642, 315);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(138, 23);
            this.updateCancel.TabIndex = 12;
            this.updateCancel.Text = "Отменить обновление";
            this.updateCancel.UseVisualStyleBackColor = true;
            this.updateCancel.Click += new System.EventHandler(this.updateCancel_Click);
            // 
            // logList
            // 
            this.logList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logList.FormattingEnabled = true;
            this.logList.Location = new System.Drawing.Point(147, 6);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(633, 286);
            this.logList.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(147, 315);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(489, 23);
            this.progressBar.TabIndex = 17;
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.Controls.Add(this.listButton);
            this.optionsTabPage.Controls.Add(this.massUpdateButton);
            this.optionsTabPage.Controls.Add(this.saveSettingsButton);
            this.optionsTabPage.Controls.Add(this.resetSettingsButton);
            this.optionsTabPage.Controls.Add(this.groupBox1);
            this.optionsTabPage.Controls.Add(this.groupBox6);
            this.optionsTabPage.Controls.Add(this.groupBox7);
            this.optionsTabPage.Controls.Add(this.groupBox5);
            this.optionsTabPage.Controls.Add(this.groupBox2);
            this.optionsTabPage.Controls.Add(this.groupBox8);
            this.optionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionsTabPage.Size = new System.Drawing.Size(813, 350);
            this.optionsTabPage.TabIndex = 1;
            this.optionsTabPage.Text = "Настройки";
            this.optionsTabPage.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSettingsButton.Location = new System.Drawing.Point(429, 269);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(203, 60);
            this.saveSettingsButton.TabIndex = 33;
            this.saveSettingsButton.Text = "Сохранить настройки";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.Location = new System.Drawing.Point(638, 306);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(146, 23);
            this.resetSettingsButton.TabIndex = 32;
            this.resetSettingsButton.Text = "Настройки по-умолчанию";
            this.resetSettingsButton.UseVisualStyleBackColor = true;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteLinkButton);
            this.groupBox1.Controls.Add(this.deletePackcageButton);
            this.groupBox1.Location = new System.Drawing.Point(670, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 67);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление";
            // 
            // deleteLinkButton
            // 
            this.deleteLinkButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteLinkButton.Location = new System.Drawing.Point(3, 41);
            this.deleteLinkButton.Name = "deleteLinkButton";
            this.deleteLinkButton.Size = new System.Drawing.Size(100, 23);
            this.deleteLinkButton.TabIndex = 19;
            this.deleteLinkButton.Text = "Линк";
            this.deleteLinkButton.UseVisualStyleBackColor = true;
            this.deleteLinkButton.Click += new System.EventHandler(this.deleteLinkButton_Click);
            // 
            // deletePackcageButton
            // 
            this.deletePackcageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletePackcageButton.Location = new System.Drawing.Point(3, 16);
            this.deletePackcageButton.Name = "deletePackcageButton";
            this.deletePackcageButton.Size = new System.Drawing.Size(100, 23);
            this.deletePackcageButton.TabIndex = 22;
            this.deletePackcageButton.Text = "Пакет";
            this.deletePackcageButton.UseVisualStyleBackColor = true;
            this.deletePackcageButton.Click += new System.EventHandler(this.deletePackcageButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkLinkLabel);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.osLabel);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lastUpdateLabel);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.storeIdLabel);
            this.groupBox6.Controls.Add(this.Склад);
            this.groupBox6.Controls.Add(this.linkNameLabel);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.dbVersionLabel);
            this.groupBox6.Controls.Add(this.packetLabel);
            this.groupBox6.Controls.Add(this.pingLabel);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(429, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 184);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сервисное";
            // 
            // checkLinkLabel
            // 
            this.checkLinkLabel.AutoSize = true;
            this.checkLinkLabel.Location = new System.Drawing.Point(135, 155);
            this.checkLinkLabel.Name = "checkLinkLabel";
            this.checkLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.checkLinkLabel.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Дотупность линка";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(135, 95);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(0, 13);
            this.osLabel.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "ОС";
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.AutoSize = true;
            this.lastUpdateLabel.Location = new System.Drawing.Point(135, 135);
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(0, 13);
            this.lastUpdateLabel.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Послед. обновление";
            // 
            // storeIdLabel
            // 
            this.storeIdLabel.AutoSize = true;
            this.storeIdLabel.Location = new System.Drawing.Point(135, 75);
            this.storeIdLabel.Name = "storeIdLabel";
            this.storeIdLabel.Size = new System.Drawing.Size(0, 13);
            this.storeIdLabel.TabIndex = 33;
            // 
            // Склад
            // 
            this.Склад.AutoSize = true;
            this.Склад.Location = new System.Drawing.Point(6, 75);
            this.Склад.Name = "Склад";
            this.Склад.Size = new System.Drawing.Size(38, 13);
            this.Склад.TabIndex = 32;
            this.Склад.Text = "Склад";
            // 
            // linkNameLabel
            // 
            this.linkNameLabel.AutoSize = true;
            this.linkNameLabel.Location = new System.Drawing.Point(135, 115);
            this.linkNameLabel.Name = "linkNameLabel";
            this.linkNameLabel.Size = new System.Drawing.Size(0, 13);
            this.linkNameLabel.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Линк";
            // 
            // dbVersionLabel
            // 
            this.dbVersionLabel.AutoSize = true;
            this.dbVersionLabel.Location = new System.Drawing.Point(135, 35);
            this.dbVersionLabel.Name = "dbVersionLabel";
            this.dbVersionLabel.Size = new System.Drawing.Size(0, 13);
            this.dbVersionLabel.TabIndex = 29;
            // 
            // packetLabel
            // 
            this.packetLabel.AutoSize = true;
            this.packetLabel.Location = new System.Drawing.Point(135, 55);
            this.packetLabel.Name = "packetLabel";
            this.packetLabel.Size = new System.Drawing.Size(0, 13);
            this.packetLabel.TabIndex = 28;
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(135, 18);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(0, 13);
            this.pingLabel.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Версия базы";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Пакет";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Пинг до сервера";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.installLinkButton);
            this.groupBox7.Controls.Add(this.installPackageButton);
            this.groupBox7.Location = new System.Drawing.Point(426, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(109, 67);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Установка";
            // 
            // installLinkButton
            // 
            this.installLinkButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.installLinkButton.Location = new System.Drawing.Point(3, 41);
            this.installLinkButton.Name = "installLinkButton";
            this.installLinkButton.Size = new System.Drawing.Size(103, 23);
            this.installLinkButton.TabIndex = 19;
            this.installLinkButton.Text = "Линк";
            this.installLinkButton.UseVisualStyleBackColor = true;
            this.installLinkButton.Click += new System.EventHandler(this.installLinkButton_Click);
            // 
            // installPackageButton
            // 
            this.installPackageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.installPackageButton.Location = new System.Drawing.Point(3, 16);
            this.installPackageButton.Name = "installPackageButton";
            this.installPackageButton.Size = new System.Drawing.Size(103, 23);
            this.installPackageButton.TabIndex = 22;
            this.installPackageButton.Text = "Пакет";
            this.installPackageButton.UseVisualStyleBackColor = true;
            this.installPackageButton.Click += new System.EventHandler(this.installPackageButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.remoteLinkName);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(8, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 57);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Линк";
            // 
            // remoteLinkName
            // 
            this.remoteLinkName.Location = new System.Drawing.Point(96, 23);
            this.remoteLinkName.Name = "remoteLinkName";
            this.remoteLinkName.Size = new System.Drawing.Size(306, 20);
            this.remoteLinkName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Location = new System.Drawing.Point(8, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 127);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаленная база";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.remotePasswordTextBox);
            this.groupBox9.Controls.Add(this.remoteUserTextBox);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox9.Location = new System.Drawing.Point(215, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(194, 108);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Пользователь";
            // 
            // remotePasswordTextBox
            // 
            this.remotePasswordTextBox.Location = new System.Drawing.Point(90, 45);
            this.remotePasswordTextBox.Name = "remotePasswordTextBox";
            this.remotePasswordTextBox.PasswordChar = '*';
            this.remotePasswordTextBox.Size = new System.Drawing.Size(97, 20);
            this.remotePasswordTextBox.TabIndex = 9;
            // 
            // remoteUserTextBox
            // 
            this.remoteUserTextBox.Location = new System.Drawing.Point(90, 19);
            this.remoteUserTextBox.Name = "remoteUserTextBox";
            this.remoteUserTextBox.Size = new System.Drawing.Size(97, 20);
            this.remoteUserTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Пользователь";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Пароль";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.remoteHostTextBox);
            this.groupBox11.Controls.Add(this.remoteSidTextBox);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.remotePortTextBox);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox11.Location = new System.Drawing.Point(3, 16);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(202, 108);
            this.groupBox11.TabIndex = 22;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Соединение";
            // 
            // remoteHostTextBox
            // 
            this.remoteHostTextBox.Location = new System.Drawing.Point(90, 19);
            this.remoteHostTextBox.Name = "remoteHostTextBox";
            this.remoteHostTextBox.Size = new System.Drawing.Size(103, 20);
            this.remoteHostTextBox.TabIndex = 13;
            // 
            // remoteSidTextBox
            // 
            this.remoteSidTextBox.Location = new System.Drawing.Point(90, 45);
            this.remoteSidTextBox.Name = "remoteSidTextBox";
            this.remoteSidTextBox.Size = new System.Drawing.Size(103, 20);
            this.remoteSidTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "SID";
            // 
            // remotePortTextBox
            // 
            this.remotePortTextBox.Location = new System.Drawing.Point(90, 71);
            this.remotePortTextBox.Name = "remotePortTextBox";
            this.remotePortTextBox.Size = new System.Drawing.Size(103, 20);
            this.remotePortTextBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Хост/ip";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Порт";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox3);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Location = new System.Drawing.Point(8, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(412, 127);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Локальная база";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.localUserTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.localPasswordTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(215, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 108);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пользователь";
            // 
            // localUserTextBox
            // 
            this.localUserTextBox.Location = new System.Drawing.Point(90, 19);
            this.localUserTextBox.Name = "localUserTextBox";
            this.localUserTextBox.Size = new System.Drawing.Size(97, 20);
            this.localUserTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Пользователь";
            // 
            // localPasswordTextBox
            // 
            this.localPasswordTextBox.Location = new System.Drawing.Point(90, 45);
            this.localPasswordTextBox.Name = "localPasswordTextBox";
            this.localPasswordTextBox.PasswordChar = '*';
            this.localPasswordTextBox.Size = new System.Drawing.Size(97, 20);
            this.localPasswordTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Пароль";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.localHostTextBox);
            this.groupBox4.Controls.Add(this.localSidTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.localPortTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 108);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Соединение";
            // 
            // localHostTextBox
            // 
            this.localHostTextBox.Location = new System.Drawing.Point(90, 19);
            this.localHostTextBox.Name = "localHostTextBox";
            this.localHostTextBox.Size = new System.Drawing.Size(103, 20);
            this.localHostTextBox.TabIndex = 13;
            // 
            // localSidTextBox
            // 
            this.localSidTextBox.Location = new System.Drawing.Point(90, 45);
            this.localSidTextBox.Name = "localSidTextBox";
            this.localSidTextBox.Size = new System.Drawing.Size(103, 20);
            this.localSidTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SID";
            // 
            // localPortTextBox
            // 
            this.localPortTextBox.Location = new System.Drawing.Point(90, 71);
            this.localPortTextBox.Name = "localPortTextBox";
            this.localPortTextBox.Size = new System.Drawing.Size(103, 20);
            this.localPortTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Хост/ip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Порт";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 350);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Справка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(797, 338);
            this.label19.TabIndex = 0;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 350);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "update_log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // massUpdateButton
            // 
            this.massUpdateButton.Location = new System.Drawing.Point(556, 47);
            this.massUpdateButton.Name = "massUpdateButton";
            this.massUpdateButton.Size = new System.Drawing.Size(91, 23);
            this.massUpdateButton.TabIndex = 34;
            this.massUpdateButton.Text = "Массовый";
            this.massUpdateButton.UseVisualStyleBackColor = true;
            this.massUpdateButton.Click += new System.EventHandler(this.massUpdateButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(556, 22);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(91, 23);
            this.listButton.TabIndex = 35;
            this.listButton.Text = "Список";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 376);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер обновлений 2.4";
            this.tabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            this.optionsTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.Button fullUpdateButton;
        private System.Windows.Forms.TabPage optionsTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localSidTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox remotePasswordTextBox;
        private System.Windows.Forms.TextBox remoteUserTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox remoteHostTextBox;
        private System.Windows.Forms.TextBox remoteSidTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox remotePortTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox localUserTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox localPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox localHostTextBox;
        private System.Windows.Forms.TextBox localPortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.Button updateCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteLinkButton;
        private System.Windows.Forms.Button deletePackcageButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label dbVersionLabel;
        private System.Windows.Forms.Label packetLabel;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button installLinkButton;
        private System.Windows.Forms.Button installPackageButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox remoteLinkName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button resetSettingsButton;
        private System.Windows.Forms.Label linkNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label storeIdLabel;
        private System.Windows.Forms.Label Склад;
        private System.Windows.Forms.Label lastUpdateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox bar_codesCheckBox;
        private System.Windows.Forms.CheckBox prices_cacheCheckBox;
        private System.Windows.Forms.CheckBox itemsCheckBox;
        private System.Windows.Forms.CheckBox group_itemsCheckBox;
        private System.Windows.Forms.CheckBox countriesCheckBox;
        private System.Windows.Forms.CheckBox customersCheckBox;
        private System.Windows.Forms.CheckBox contractorsCheckBox;
        private System.Windows.Forms.CheckBox groupsCheckBox;
        private System.Windows.Forms.CheckBox goodsCheckBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label checkLinkLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button massUpdateButton;
        private System.Windows.Forms.Button listButton;
    }
}

