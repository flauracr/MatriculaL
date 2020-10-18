using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CapaEntidades;

namespace CapaAD
{
    class MateriasAbiertasAD
    {

        private string _cadenaConexion;
        private string mensaje;
        public string Mensaje
        {
            get => mensaje;
        }
        public MateriasAbiertasAD()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public MateriasAbiertasAD(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }


    }//clase
}//namespace
