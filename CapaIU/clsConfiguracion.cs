using System;
using System.Collections.Generic;
using System.Text;

namespace CapaIU
{
    class clsConfiguracion
    {
        public static string getconnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
        }

    }//clase
}//namespace
