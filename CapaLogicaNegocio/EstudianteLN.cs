using System;

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

        public int Insertar(EntidadCliente pEntidadCliente)
        {
            int id = 0;
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                id = vlo_DACliente.Insertar(pEntidadCliente);
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
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                DS = vlo_DACliente.ListarRegistros(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listasregistros
        public List<EntidadCliente> ListarRegistros1(string condicion = "")
        {
            List<EntidadCliente> Lista;
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                Lista = vlo_DACliente.ListarRegistros1(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listasregistros
        public EntidadCliente ObtenerCliente(string condicion)
        {
            EntidadCliente cliente;
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                cliente = vlo_DACliente.ObtenerCliente(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;

        }

        public int Modificar(EntidadCliente pEntidadCliente)
        {
            int cant = 0;
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                cant = vlo_DACliente.Modificar(pEntidadCliente);
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }
        public int Eliminar(EntidadCliente pEntidadCliente)
        {
            int cant = 0;
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                cant = vlo_DACliente.Eliminar(pEntidadCliente);
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
            DACliente vlo_DACliente = new DACliente(_cadenaConexion);
            try
            {
                cant = vlo_DACliente.Eliminar(id);
                mensaje = vlo_DACliente.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return cant;
        }

    }
}
