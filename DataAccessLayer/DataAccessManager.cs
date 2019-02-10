using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccessLayer.Extentions;
using DataAccessLayer.DataAccessTools;

namespace DataAccessLayer
{
    public class DataAccessManager
    {
        public static IEnumerable<T> ExexuteSPWithResult<T>(string procedureName) where T : class, new()
        {
            List<T> list = new List<T>();

            using (SqlConnection connection = DataAccessTools.DataConnector.GetConnection())
            {
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T obj = reader.MapEntity<T>();
                        list.Add(obj);
                    }
                    return list;
                }

            }
        }

        public static void ExecuteSpNonQuery(string procedureName, List<StoredProcedureParameters> parameters)
        {
            using (SqlConnection connection = DataConnector.GetConnection())
            {
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                for (int i = 0; i < parameters.Count; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
                command.ExecuteNonQuery();
            }
        }

    }
      




     
}
