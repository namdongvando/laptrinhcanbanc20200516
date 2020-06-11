using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SuDungSQLServer
{
    class AdapterSQL
    {
        protected static string ConnectionString = ConfigurationManager.
            ConnectionStrings["SuDungSQLServer.Properties.Settings.MyeStoreConnectionString"]
            .ConnectionString.ToString(); 


    }
}
