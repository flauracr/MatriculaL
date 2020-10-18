using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CapaEntidades;


namespace CapaAD
{
    public class MateriasAD
    {
        private string _cadenaConexion;
        private string mensaje;
        public string Mensaje
        {
            get => mensaje;
        }
        public MateriasAD()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public MateriasAD(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }


        public int Insertar(EntidadMaterias pEntidadMaterias)
        {
            SqlConnection vlo_sqlConexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_sqlCommand = new SqlCommand();
            int idMateria = 0;
            string sentencia = string.Empty;
            vlo_sqlCommand.Connection = vlo_sqlConexion;
            try
            {
                sentencia = "INSERT INTO MATERIAS (CODIGO_MATERIA, NOMBRE_MATERIA, HORAS_TOTALES) " +
                    "VALUES (@CodigoMateria, @NombreMateria,@HorasTotales) SELECT @@Identity";
               
                vlo_sqlCommand.Parameters.AddWithValue("@CodigoMateria", pEntidadMaterias.CodMateria);
                vlo_sqlCommand.Parameters.AddWithValue("@NombreMateria", pEntidadMaterias.NombreMatertia);
                vlo_sqlCommand.Parameters.AddWithValue("@HorasTotales", pEntidadMaterias.HorasTotales);
                
                vlo_sqlCommand.CommandText = sentencia;
                vlo_sqlConexion.Open();
                idMateria = Convert.ToInt32(vlo_sqlCommand.ExecuteScalar());
                vlo_sqlConexion.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                vlo_sqlConexion.Dispose();
                vlo_sqlCommand.Dispose();
            }
            return idMateria;
        }//fin de insertar

        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;

            string sentencia;
            try
            {
                sentencia = "SELECT ID_MATERIA, CODIGO_MATERIA, NOMBRE_MATERIA, HORAS_TOTALES from MATERIAS";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Materias");
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listar registros


        public List<EntidadMaterias> ListarRegistros1(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;
            List<EntidadMaterias> Lista = new List<EntidadMaterias>();
            string sentencia;
            try
            {
                sentencia = "SELECT ID_MATERIA, CODIGO_MATERIA, NOMBRE_MATERIA, HORAS_TOTALES from MATERIAS";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Materias");
                //sentencia linq para crear una lista a partir de un DataTable
                Lista = (from DataRow registro in DS.Tables[0].Rows
                         select new EntidadMaterias()
                         {
                             IdMateria = (int)registro["ID_MATERIA"],
                             CodMateria = registro["CODIGO_MATERIA"].ToString(),
                             NombreMatertia = registro["NOMBRE_MATERIA"].ToString(),
                             HorasTotales = (int)registro["HORAS_TOTALES"],
                             
                         }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listar registros

        public EntidadMaterias ObtenerMateria(string condicion)
        {
            EntidadMaterias materias = new EntidadMaterias();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_comando = new SqlCommand();
            SqlDataReader vlo_reader;
            string sentencia;
            vlo_comando.Connection = vlo_conexion;
            sentencia = "Select ID_MATERIA, CODIGO_MATERIA, NOMBRE_MATERIA, HORAS_TOTALES from MATERIAS";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            try
            {
                vlo_comando.CommandText = sentencia;
                vlo_conexion.Open();
                vlo_reader = vlo_comando.ExecuteReader();
                if (vlo_reader.HasRows)
                {
                    vlo_reader.Read();
                    materias.IdMateria = vlo_reader.GetInt32(0);
                    materias.CodMateria = vlo_reader.GetString(1);
                    materias.NombreMatertia = vlo_reader.GetString(2);
                    materias.HorasTotales = vlo_reader.GetInt32(3);
                    
                   materias.ExisteRegistro = true;

                }
                vlo_conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vlo_comando.Dispose();
                vlo_conexion.Dispose();
            }
            return materias;
        }//obtener estudiante


        public int Modificar(EntidadMaterias pEntidadMaterias)
        {
            int resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string Sentencia = string.Empty;
            vlo_Command.Connection = vlo_Conexion;
            vlo_Command.Parameters.AddWithValue("@IdMateria", pEntidadMaterias.IdMateria);
            vlo_Command.Parameters.AddWithValue("@CodMateria", pEntidadMaterias.CodMateria);
            vlo_Command.Parameters.AddWithValue("@NombreMateria", pEntidadMaterias.NombreMatertia);
            vlo_Command.Parameters.AddWithValue("@HorasTotales", pEntidadMaterias.HorasTotales.ToString());
            Sentencia = "UPDATE MATERIAS SET CODIGO_MATERIA=@CodMateria,NOMBRE_MATERIA=@NombreMateria,HORAS_TOTALES=@HorasTotales" +
                " WHERE ID_MATERIA=@IdMateria";
            try
            {
                vlo_Command.CommandText = Sentencia;
                vlo_Conexion.Open();
                resultado = vlo_Command.ExecuteNonQuery();
                vlo_Conexion.Close();
            }
            catch (Exception)
            {
                resultado = -1;
                throw;
            }
            finally
            {
                vlo_Command.Dispose();
                vlo_Conexion.Dispose();
            }
            return resultado;
        }// fin de modificar

        public int Eliminar(EntidadMaterias pEntidadMaterias)
        {
            int resultado = -1;
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_command = new SqlCommand();
            string sentencia;
            vlo_command.Connection = vlo_conexion;
            vlo_command.Parameters.AddWithValue("@Id", pEntidadMaterias.IdMateria);
            sentencia = "DELETE FROM MATERIAS WHERE ID_MATERIA=@Id";
            vlo_command.CommandText = sentencia;
            try
            {
                vlo_conexion.Open();
                resultado = vlo_command.ExecuteNonQuery();
                vlo_conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vlo_command.Dispose();
                vlo_conexion.Dispose();
            }
            return resultado;
        }//eliminar

        public int Eliminar(int id)
        {
            int resultado = -1;
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_command = new SqlCommand();
            vlo_command.Connection = vlo_conexion;
            vlo_command.CommandType = CommandType.StoredProcedure;
            vlo_command.CommandText = "SP_ELIMINAR_MATERIA";
            //parametro de entrada
            vlo_command.Parameters.AddWithValue("@id", id);
            //parametro de salida
            vlo_command.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            try
            {
                vlo_conexion.Open();
                resultado = vlo_command.ExecuteNonQuery();
                //leer el parametro de salida
                mensaje = Convert.ToString(vlo_command.Parameters["@msj"].Value);
                vlo_conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vlo_command.Dispose();
                vlo_conexion.Dispose();
            }
            return resultado;
        }

    }//clase
}//namespace
