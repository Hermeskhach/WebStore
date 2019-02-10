using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessLayer.DataAccessTools
{
    class DataConnector:IDisposable
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection(DataConfig.ConnectionString);
            connection.Open();
            return connection;
        }

        public void Dispose()
        {
            if (connection!=null)
            {
                connection.Close();
            }
        }
    }
}
