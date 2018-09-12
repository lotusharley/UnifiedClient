using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underflow
{
    public class ClientConfig
    {
        private static ClientConfig _instance;
        private static object locker = new object();

        private Dictionary<string, string> dic_Config;

        private ClientConfig()
        {
            dic_Config = new Dictionary<string, string>();

            string sPathCurrentWorkingFolder = AppDomain.CurrentDomain.BaseDirectory;
            dic_Config.Add("working_folder", sPathCurrentWorkingFolder);
        }

        public static ClientConfig GetInstance()
        {
            lock(locker)
            {
                if(_instance == null)
                {
                    _instance = new ClientConfig();
                }
            }
            return _instance;
        }

        public string GetConfig(string sKey)
        {
            if (dic_Config.ContainsKey(sKey))
                return dic_Config[sKey];
            else
                return string.Empty;
        }

    }
}
