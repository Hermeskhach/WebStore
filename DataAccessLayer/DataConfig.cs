using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class DataConfig
    {
        internal static string ConnectionString { get; private set; }

        public DataConfig(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection"); 
        }
    }
}
