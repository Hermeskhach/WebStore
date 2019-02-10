using Microsoft.Extensions.Configuration;
using System;
using DataAccessLayer;

namespace BisnessLayer
{
    public class LayerConfig
    {
        

        public LayerConfig(IConfiguration configuration)
        {
            DataConfig conf = new DataConfig(configuration);
        }

    }
}
