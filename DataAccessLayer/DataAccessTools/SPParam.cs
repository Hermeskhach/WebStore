namespace DataAccessLayer.DataAccessTools
{
    public class SPParam
    {
        public string ParameterName { get; private set; }
        public object ParameterValue { get; private set; }

        public SPParam(string paramName, object paramValue)
        {
            ParameterName = paramName;
            ParameterValue = paramValue;
        }

    }
}
