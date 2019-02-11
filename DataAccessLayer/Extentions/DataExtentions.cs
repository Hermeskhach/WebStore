using FastMember;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Extentions
{
    public static class DataExtentions
    {
        public static T MapEntity<T>(this SqlDataReader reader) where T : class, new()
        {
            Type type = typeof(T);
            var accessor = TypeAccessor.Create(type);
            var members = accessor.GetMembers();
            var obj = new T();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (!reader.IsDBNull(i))
                {
                    string colName = reader.GetName(i);

                    if (members.Any(m => string.Equals(m.Name, colName, StringComparison.OrdinalIgnoreCase)))
                    {
                        accessor[obj, colName] = reader.GetValue(i);
                    }
                }
            }

            return obj;
        }


       
    }
}
