using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Updater
{
    public static class Utilites
    {
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public static string GetLogSql() => @"SELECT
  l.signature
, l.""COMMENT""
, l.update_start UPDATE_START
, l.update_end UPDATE_END
, PRICES_CACHE, BAR_CODES, CONTRACTORS, ITEMS, GROUP_ITEMS, CUSTOMERS, GOODS,""GROUPS"", COUNTRIES
FROM abt.update_log2 l WHERE ROWNUM< 40 ORDER BY l.update_start desc";

    }
}
