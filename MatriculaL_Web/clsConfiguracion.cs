using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MatriculaL_Web
{
    public static class clsConfiguracion
    {
        public static string getconnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];

            }
        }
    }
}