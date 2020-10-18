using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadesWeb;
using CapaADWeb;
using System.Data;


namespace CapaLNWeb
{
    public class ProfesorLN
    {
        private string _cadenaConexion;
        private string mensaje;

        public string Mensaje
        {
            get => mensaje;
        }
        public ProfesorLN()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public ProfesorLN(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }

        public int Insertar(EntidadProfesor pEntidadProfesor)
        {
            int id = 0;
            ProfesorAD vlo_DAProfesor = new ProfesorAD(_cadenaConexion);
            try
            {
                id = vlo_DAProfesor.Insertar(pEntidadProfesor);
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }


        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                DS = vlo_ProfesorAD.ListarRegistros(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listasregistros


        public List<EntidadProfesor> ListarRegistros1(string condicion = "")
        {
            List<EntidadProfesor> Lista;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                Lista = vlo_ProfesorAD.ListarRegistros1(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listasregistros


        public EntidadProfesor ObtenerProfesor(string condicion)
        {
            EntidadProfesor profesor;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                profesor = vlo_ProfesorAD.ObtenerProfesor(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return profesor;
        }

        public int Modificar(EntidadProfesor pEntidadProfesor)
        {
            int cant = 0;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                cant = vlo_ProfesorAD.Modificar(pEntidadProfesor);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }//modificar

        public int Eliminar(EntidadProfesor pEntidadProfesor)
        {
            int cant = 0;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                cant = vlo_ProfesorAD.Eliminar(pEntidadProfesor);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }//eliminar

        public int Eliminar(int id)
        {
            int cant = 0;
            ProfesorAD vlo_ProfesorAD = new ProfesorAD(_cadenaConexion);
            try
            {
                cant = vlo_ProfesorAD.Eliminar(id);
                mensaje = vlo_ProfesorAD.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }//eliminar con id
    }//clase
}//namespace
