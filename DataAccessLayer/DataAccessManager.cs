using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccessLayer.Extentions;
using DataAccessLayer.DataAccessTools;

namespace DataAccessLayer
{
    public class DataAccessManager
    {
        internal protected static IEnumerable<T> ExexuteSPWithResult<T>(string procedureName) where T : class, new()
        {
            List<T> list = new List<T>();

            using (SqlConnection connection = DataConnector.GetConnection())
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

        internal protected static void ExecuteSpNonQuery(string procedureName, List<SPParam> parameters)
        {
            using (SqlConnection connection = DataConnector.GetConnection())
            {
                SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                for (int i = 0; i < parameters.Count; i++)
                {
                    command.Parameters.Add(new SqlParameter( parameters[i].ParameterName, parameters[i].ParameterValue));
                }
                command.ExecuteNonQuery();
            }
        }

    }






}
