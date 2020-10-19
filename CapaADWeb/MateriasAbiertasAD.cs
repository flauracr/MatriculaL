using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadesWeb;
using System.Data.SqlClient;
using System.Data;


namespace CapaADWeb
{
    public class MateriasAbiertasAD
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

        public int Insertar(EstidadMateriaAbierta pEntidadMateriasAbiertas)
        {
            ProfesorAD profesorAD = new ProfesorAD(this._cadenaConexion);
            var profesores = profesorAD.ListarRegistros1("ID_PROFESOR=" + pEntidadMateriasAbiertas.CedulaProfesor);
            string cedula = string.Empty;
            if (profesores.Count > 0) 
            {
                cedula = profesores[0].CedulaProfesor;
            }

            SqlConnection vlo_sqlConexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_sqlCommand = new SqlCommand();
            int idMateriaA = 0;
            string sentencia = string.Empty;
            vlo_sqlCommand.Connection = vlo_sqlConexion;
            try
            {
                sentencia = "INSERT INTO MATERIAS_ABIERTAS (ID_MATERIA, CEDULA_PROFESOR, GRUPO, CUPO, ANIO) " +
                    "VALUES (@IdMateria, @CedulaProfesor, @GRUPO, @CUPO, @ANNIO) SELECT @@Identity";

                vlo_sqlCommand.Parameters.AddWithValue("@IdMateria", pEntidadMateriasAbiertas.IdMateria);
                vlo_sqlCommand.Parameters.AddWithValue("@CedulaProfesor", cedula);
                vlo_sqlCommand.Parameters.AddWithValue("@GRUPO", pEntidadMateriasAbiertas.Grupo);
                vlo_sqlCommand.Parameters.AddWithValue("@CUPO", pEntidadMateriasAbiertas.Cupo);
                vlo_sqlCommand.Parameters.AddWithValue("@ANNIO", pEntidadMateriasAbiertas.Anio);

                vlo_sqlCommand.CommandText = sentencia;
                vlo_sqlConexion.Open();
                idMateriaA = vlo_sqlCommand.ExecuteNonQuery();
                vlo_sqlConexion.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
            finally
            {
                vlo_sqlConexion.Dispose();
                vlo_sqlCommand.Dispose();
            }
            return idMateriaA;
        }//fin de insertar

        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;

            string sentencia;
            try
            {
                sentencia = "SELECT ID_MATERIA_ABIERTA, ID_MATERIA, CEDULA_PROFESOR, GRUPO, CUPO, ANIO from MATERIAS_ABIERTAS";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "MateriasA");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
            return DS;
        }//listar registros


        public List<EstidadMateriaAbierta> ListarRegistros1(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;
            List<EstidadMateriaAbierta> Lista = new List<EstidadMateriaAbierta>();
            string sentencia;
            try
            {
                sentencia = "SELECT ID_MATERIA_ABIERTA, ID_MATERIA, CEDULA_PROFESOR, GRUPO, CUPO, ANIO from MATERIAS_ABIERTAS"; 
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "MateriasA");
                //sentencia linq para crear una lista a partir de un DataTable
                Lista = (from DataRow registro in DS.Tables[0].Rows
                         select new EstidadMateriaAbierta()
                         {
                             IdMateriaAbierta = (int)registro["ID_MATERIA_ABIERTA"],
                             IdMateria = (int)registro["ID_MATERIA"],
                             CedulaProfesor = registro["CEDULA_PROFESOR"].ToString(),
                             Grupo = (int)registro["GRUPO"],
                             Cupo = (int)registro["CUPO"],
                             Anio = registro["ANIO"].ToString(),

                         }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listar registros

        public EstidadMateriaAbierta ObtenerMateria(string condicion)
        {
            EstidadMateriaAbierta materiasA = new EstidadMateriaAbierta();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_comando = new SqlCommand();
            SqlDataReader vlo_reader;
            string sentencia;
            vlo_comando.Connection = vlo_conexion;
            sentencia = "SELECT ID_MATERIA_ABIERTA, ID_MATERIA, CEDULA_PROFESOR, GRUPO, CUPO, ANIO from MATERIAS_ABIERTAS";
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
                    materiasA.IdMateriaAbierta = vlo_reader.GetInt32(0);
                    materiasA.IdMateria = vlo_reader.GetInt32(1);
                    materiasA.CedulaProfesor = vlo_reader.GetString(2);
                    materiasA.Grupo= vlo_reader.GetInt32(3);
                    materiasA.Cupo = vlo_reader.GetInt32(4);
                    materiasA.Anio = vlo_reader.GetString(2);
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
            return materiasA;
        }//obtener estudiante


        public int Modificar(EstidadMateriaAbierta pEntidadMateriasAbiertas)
        {
            int resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string Sentencia = string.Empty;
            vlo_Command.Connection = vlo_Conexion;
            vlo_Command.Parameters.AddWithValue("@IdMateriaAbierta", pEntidadMateriasAbiertas.IdMateriaAbierta);
            vlo_Command.Parameters.AddWithValue("@IdMateria", pEntidadMateriasAbiertas.IdMateria);
            vlo_Command.Parameters.AddWithValue("@CedulaProfesor", pEntidadMateriasAbiertas.CedulaProfesor);
            vlo_Command.Parameters.AddWithValue("@Grupo", pEntidadMateriasAbiertas.Grupo);
            vlo_Command.Parameters.AddWithValue("@Cupo", pEntidadMateriasAbiertas.Cupo);
            vlo_Command.Parameters.AddWithValue("@Anio", pEntidadMateriasAbiertas.Anio);
            Sentencia = "UPDATE MATERIAS_ABIERTAS SET ID_MATERIA=@IdMateria,CEDULA_PROFESOR=@CedulaProfesor,GRUPO=@Grupo, CUPO=@Cupo, ANIO=@Anio" +
                " WHERE ID_MATERIA_ABIERTA=@IdMateriaAbierta";
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

        public int Eliminar(EstidadMateriaAbierta pEntidadMateriasAbiertas)
        {
            int resultado = -1;
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_command = new SqlCommand();
            string sentencia;
            vlo_command.Connection = vlo_conexion;
            vlo_command.Parameters.AddWithValue("@Id", pEntidadMateriasAbiertas.IdMateria);
            sentencia = "DELETE FROM MATERIAS_ABIERTAS WHERE ID_MATERIA_ABIERTA =@Id";
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
            vlo_command.CommandText = "SP_ELIMINAR_MATERIA_ABIERTA";
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
