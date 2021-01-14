using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformSqliteAsStoreConf
{
    public sealed class ConfParser
    {
        private SQLiteDatabase appSettingsDB = new SQLiteDatabase();

        private ConfParser()
        {
            //bool rs = appSettingsDB.Create(Path.ChangeExtension(Application.ExecutablePath, "db"), false, null, true);
            bool rs = appSettingsDB.Create("dbsettings.db", false, null, true);
            if (!rs)
            {
                MessageBox.Show(appSettingsDB.LastError);
                return;
            }
        }

        private static readonly Lazy<ConfParser> lazy = new Lazy<ConfParser>(() => new ConfParser());
        public static ConfParser Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// Read Key (string)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string ReadKey(string section, string key)
        {
            var res = appSettingsDB.GetConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Read Key (int)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int ReadKey(string section, int key)
        {
            var res = appSettingsDB.GetIntConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Read Key (bool)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ReadKey(string section, bool key)
        {
            var res = appSettingsDB.GetBoolConfig(section + "_" + key);
            return res;
        }

        /// <summary>
        /// Write key (string)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void WriteKey(string section, string key, string value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }

        /// <summary>
        /// Write Key (int)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void WriteKey(string section, string key, int value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }

        /// <summary>
        /// Write Key (bool)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void WriteKey(string section, string key, bool value)
        {
            appSettingsDB.SetConfig(section + "_" + key, value);
        }
    }

}
