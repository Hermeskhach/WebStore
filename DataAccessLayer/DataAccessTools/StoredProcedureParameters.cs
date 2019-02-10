using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccessTools
{
   public class StoredProcedureParameters
    {
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }

        public StoredProcedureParameters(string paramName, object paramValue)
        {
            ParameterName = paramName;
            ParameterValue = paramValue;
        }

    }
}
