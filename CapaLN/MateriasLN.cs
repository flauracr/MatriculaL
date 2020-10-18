using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAD;
using System.Data;

namespace CapaLN
{
    public class MateriasLN
    {
        private string _cadenaConexion;
        private string mensaje;

        public string Mensaje
        {
            get => mensaje;
        }
        public MateriasLN()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public MateriasLN(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }


        public int Insertar(EntidadMaterias pEntidadMaterias)
        {
            int id = 0;
            MateriasAD vlo_DAMaterias = new MateriasAD(_cadenaConexion);
            try
            {
                id = vlo_DAMaterias.Insertar(pEntidadMaterias);
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
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                DS = vlo_MateriasAD.ListarRegistros(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listasregistros

        public List<EntidadMaterias> ListarRegistros1(string condicion = "")
        {
            List<EntidadMaterias> Lista;
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                Lista = vlo_MateriasAD.ListarRegistros1(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listasregistros

        public EntidadMaterias ObtenerMateria(string condicion)
        {
            EntidadMaterias materias;
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                materias = vlo_MateriasAD.ObtenerMateria(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return materias;

        }

        public int Modificar(EntidadMaterias pEntidadMaterias)
        {
            int cant = 0;
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                cant = vlo_MateriasAD.Modificar(pEntidadMaterias);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

        public int Eliminar(EntidadMaterias pEntidadMaterias)
        {
            int cant = 0;
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                cant = vlo_MateriasAD.Eliminar(pEntidadMaterias);
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
            MateriasAD vlo_MateriasAD = new MateriasAD(_cadenaConexion);
            try
            {
                cant = vlo_MateriasAD.Eliminar(id);
                mensaje = vlo_MateriasAD.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

    }//clase
}//namespace
