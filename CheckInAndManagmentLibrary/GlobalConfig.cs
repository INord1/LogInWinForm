using CheckInAndManagmentLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnacnetion (DataBaseType db)
        {
            if(db == DataBaseType.sql)
            {
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }

           else if (db == DataBaseType.text)
            {
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;


           
        }
    }
}
