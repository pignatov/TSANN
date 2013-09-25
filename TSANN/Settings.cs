using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plig.TimeSeries.Client
{
    sealed class Settings
    {
        string mAlchemiURL;

        public string AlchemiURL
        {
            get { return mAlchemiURL; }
        }

        int mAlchemiPort;

        public int AlchemiPort
        {
            get { return mAlchemiPort; }
        }

        string mAlchemiUser;

        public string AlchemiUser
        {
            get { return mAlchemiUser; }
        }

        string mAlchemiPassword;

        public string AlchemiPassword
        {
            get { return mAlchemiPassword; }
        }

        private Settings() { }

        public static Settings LoadSettings()
        {
            MainDataSetTableAdapters.SETTINGSTableAdapter adptSettings = new MainDataSetTableAdapters.SETTINGSTableAdapter();
            MainDataSet.SETTINGSDataTable tblSettings = adptSettings.GetData();
            MainDataSet.SETTINGSRow settings = (MainDataSet.SETTINGSRow)tblSettings.Rows[0];

            Settings loaded_settings = new Settings();
            loaded_settings.mAlchemiURL = settings.ALCHEMI_SERVER_URL;
            loaded_settings.mAlchemiPort = settings.ALCHEMI_PORT;
            loaded_settings.mAlchemiUser = settings.ALCHEMI_USERNAME;
            loaded_settings.mAlchemiPassword = settings.ALCHEMI_PASSWORD;
            return loaded_settings;
        }
    }
}
