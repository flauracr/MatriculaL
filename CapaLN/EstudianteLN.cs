using System;
using CapaEntidades;
using CapaAD;
using System.Data;
using System.Collections.Generic;


namespace CapaLN
{
    public class EstudianteLN
    {
        private string _cadenaConexion;
        private string mensaje;

        public string Mensaje
        {
            get => mensaje;
        }
        public EstudianteLN()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public EstudianteLN(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }

        public int Insertar(EntidadEstudiante pEntidadEstudiante)
        {
            int id = 0;
            EstudianteAD vlo_DAEstudiante = new EstudianteAD(_cadenaConexion);
            try
            {
                id = vlo_DAEstudiante.Insertar(pEntidadEstudiante);
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
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                DS = vlo_EstudianteAD.ListarRegistros(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listasregistros

        public List<EntidadEstudiante> ListarRegistros1(string condicion = "")
        {
            List<EntidadEstudiante> Lista;
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                Lista = vlo_EstudianteAD.ListarRegistros1(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listasregistros

        public EntidadEstudiante ObtenerEstudiante(string condicion)
        {
            EntidadEstudiante estudiante;
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                estudiante = vlo_EstudianteAD.ObtenerEstudiante(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return estudiante;

        }
        
        public int Modificar(EntidadEstudiante pEntidadEstudiante)
        {
            int cant = 0;
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                cant = vlo_EstudianteAD.Modificar(pEntidadEstudiante);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

        public int Eliminar(EntidadEstudiante pEntidadEstudiante)
        {
            int cant = 0;
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                cant = vlo_EstudianteAD.Eliminar(pEntidadEstudiante);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

        public int Eliminar(int id)
        {
            int cant = 0;
            EstudianteAD vlo_EstudianteAD = new EstudianteAD(_cadenaConexion);
            try
            {
                cant = vlo_EstudianteAD.Eliminar(id);
                mensaje = vlo_EstudianteAD.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

    }//clase
}//namespace
