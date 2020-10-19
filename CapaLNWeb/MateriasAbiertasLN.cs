using System;
using System.Collections.Generic;
using CapaEntidadesWeb;
using CapaADWeb;
using System.Data;

namespace CapaLNWeb
{
    public class MateriasAbiertasLN
    {

        private string _cadenaConexion;
        private string mensaje;

        public string Mensaje
        {
            get => mensaje;
        }
        public MateriasAbiertasLN()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public MateriasAbiertasLN(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }

        public int Insertar(EstidadMateriaAbierta pEntidadMateriaAbierta)
        {
            int id = 0;
            MateriasAbiertasAD vlo_DAMateriaAbierta = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                id = vlo_DAMateriaAbierta.Insertar(pEntidadMateriaAbierta);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
            return id;
        }

        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS;
            MateriasAbiertasAD vlo_MateriasAbiertasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                DS = vlo_MateriasAbiertasAD.ListarRegistros(condicion);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
            return DS;
        }//listasregistros

        public List<EstidadMateriaAbierta> ListarRegistros1(string condicion = "")
        {
            List<EstidadMateriaAbierta> Lista;
            MateriasAbiertasAD vlo_MateriasAbiertasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                Lista = vlo_MateriasAbiertasAD.ListarRegistros1(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listasregistros

        public EstidadMateriaAbierta ObtenerMateria(string condicion)
        {
            EstidadMateriaAbierta materiasA;
            MateriasAbiertasAD vlo_MateriasAbiertasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                materiasA = vlo_MateriasAbiertasAD.ObtenerMateria(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return materiasA;

        }

        public int Modificar(EstidadMateriaAbierta pEntidadMateriasAbiertas)
        {
            int cant = 0;
            MateriasAbiertasAD vlo_MateriasAbiertasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                cant = vlo_MateriasAbiertasAD.Modificar(pEntidadMateriasAbiertas);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

        public int Eliminar(EstidadMateriaAbierta pEntidadMateriasAbiertas)
        {
            int cant = 0;
            MateriasAbiertasAD vlo_MateriasAbiertasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                cant = vlo_MateriasAbiertasAD.Eliminar(pEntidadMateriasAbiertas);
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
            MateriasAbiertasAD vlo_MateriasAD = new MateriasAbiertasAD(_cadenaConexion);
            try
            {
                //cant = vlo_MateriasAbiertasAD.Eliminar(id);
                //mensaje = vlo_MateriasAbiertasAD.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }
    }//clase
}//namespace
