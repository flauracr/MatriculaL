using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Web;


namespace CapaAD_Web
{
    public class EstudianteADWeb
    {
        private string _cadenaConexion;
        private string mensaje;
        public string Mensaje
        {
            get => mensaje;
        }
        public EstudianteADWeb()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public EstudianteADWeb(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }

        public int Insertar(EntidadEstudianteWeb pEntidadEstudiante)
        {
            SqlConnection vlo_sqlConexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_sqlCommand = new SqlCommand();
            int idEstudiante = 0;
            string sentencia = string.Empty;
            vlo_sqlCommand.Connection = vlo_sqlConexion;
            try
            {
                sentencia = "INSERT INTO ESTUDIANTES (CEDULA_ESTUDIANTE, NOMBRE_ESTUDIANTE,PRIMER_APELLIDO_E, SEGUNDO_APELLIDO_E, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE) " +
                    "VALUES (@CedulaEstudiante, @NombreEstudiante,@PrimerApellidoE, @SegundoApellidoE, @TelefonoEstudiante, @CorreoEstudiante) SELECT @@Identity";
                //SCOPE_IDENTITY()
                //IDENT_CURRENT("TABLA")
                vlo_sqlCommand.Parameters.AddWithValue("@CedulaEstudiante", pEntidadEstudiante.CedulaEstudiante);
                vlo_sqlCommand.Parameters.AddWithValue("@NombreEstudiante", pEntidadEstudiante.NombreEstudiante);
                vlo_sqlCommand.Parameters.AddWithValue("@PrimerApellidoE", pEntidadEstudiante.Apellido1Estudiante);
                vlo_sqlCommand.Parameters.AddWithValue("@SegundoApellidoE", pEntidadEstudiante.Apellido2Estudiante);
                vlo_sqlCommand.Parameters.AddWithValue("@TelefonoEstudiante", pEntidadEstudiante.TelefonoEstudiante);
                vlo_sqlCommand.Parameters.AddWithValue("@CorreoEstudiante", pEntidadEstudiante.CorreoEstudiante);
                //vlo_sqlCommand.Parameters.AddWithValue("@FechaIngreso", pEntidadEstudiante.FechaIngreso);
                //vlo_sqlCommand.Parameters.AddWithValue("@EstadoEstudiante", pEntidadEstudiante.EstadoEstudiante);
                vlo_sqlCommand.CommandText = sentencia;
                vlo_sqlConexion.Open();
                idEstudiante = Convert.ToInt32(vlo_sqlCommand.ExecuteScalar());
                vlo_sqlConexion.Close();
            }
            catch (Exception)
            {
                //id = -1;
                throw;
            }
            finally
            {
                vlo_sqlConexion.Dispose();
                vlo_sqlCommand.Dispose();
            }
            return idEstudiante;
        }//fin de insertar

        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;

            string sentencia;
            try
            {
                sentencia = "Select ID_ESTUDIANTE, CEDULA_ESTUDIANTE, NOMBRE_ESTUDIANTE, PRIMER_APELLIDO_E, SEGUNDO_APELLIDO_E, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE from ESTUDIANTES";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Estudiantes");
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listar registros

        public List<EntidadEstudianteWeb> ListarRegistros1(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;
            List<EntidadEstudianteWeb> Lista = new List<EntidadEstudianteWeb>();
            string sentencia;
            try
            {
                sentencia = "Select ID_ESTUDIANTE, CEDULA_ESTUDIANTE, NOMBRE_ESTUDIANTE, PRIMER_APELLIDO_E, SEGUNDO_APELLIDO_E, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE, FECHA_INGRESO, ESTADO_ESTUDIANTE from ESTUDIANTES";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Estudiantes");
                //sentencia linq para crear una lista a partir de un DataTable
                Lista = (from DataRow registro in DS.Tables[0].Rows
                         select new EntidadEstudianteWeb()
                         {
                             Id = (int)registro["ID_ESTUDIANTE"],
                             CedulaEstudiante = registro["CEDULA_ESTUDIANTE"].ToString(),
                             NombreEstudiante = registro["NOMBRE_ESTUDIANTE"].ToString(),
                             Apellido1Estudiante = registro["PRIMER_APELLIDO_E"].ToString(),
                             Apellido2Estudiante = registro["SEGUNDO_APELLIDO_E"].ToString(),
                             TelefonoEstudiante = registro["TELEFONO_ESTUDIANTE"].ToString(),
                             CorreoEstudiante = registro["CORREO_ESTUDIANTE"].ToString(),
                             FechaIngreso = registro["FECHA_INGRESO"].ToString(),
                             EstadoEstudiante = registro["ESTADO_ESTUDIANTE"].ToString(),
                         }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listar registros

        public EntidadEstudianteWeb ObtenerEstudiante(string condicion)
        {
            EntidadEstudianteWeb estudiante = new EntidadEstudianteWeb();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_comando = new SqlCommand();
            SqlDataReader vlo_reader;
            string sentencia;
            vlo_comando.Connection = vlo_conexion;
            sentencia = "Select ID_ESTUDIANTE, CEDULA_ESTUDIANTE, NOMBRE_ESTUDIANTE, PRIMER_APELLIDO_E, SEGUNDO_APELLIDO_E, TELEFONO_ESTUDIANTE, CORREO_ESTUDIANTE, FECHA_INGRESO, ESTADO_ESTUDIANTE from ESTUDIANTES";
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
                    estudiante.Id = vlo_reader.GetInt32(0);
                    estudiante.CedulaEstudiante = vlo_reader.GetString(1);
                    estudiante.NombreEstudiante = vlo_reader.GetString(2);
                    estudiante.Apellido1Estudiante = vlo_reader.GetString(3);
                    estudiante.Apellido2Estudiante = vlo_reader.GetString(4);
                    estudiante.TelefonoEstudiante = vlo_reader.GetString(5);
                    estudiante.CorreoEstudiante = vlo_reader.GetString(6);
                    //estudiante.FechaIngreso = vlo_reader.GetString(7);
                    estudiante.EstadoEstudiante = vlo_reader.GetString(8);
                    estudiante.ExisteRegistro = true;

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
            return estudiante;
        }//obtener estudiante

        public int Modificar(EntidadEstudianteWeb pEntidadEstudiante)
        {
            int resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string Sentencia = string.Empty;
            vlo_Command.Connection = vlo_Conexion;
            vlo_Command.Parameters.AddWithValue("@Id", pEntidadEstudiante.Id);
            vlo_Command.Parameters.AddWithValue("@CedulaEstudiante", pEntidadEstudiante.CedulaEstudiante);
            vlo_Command.Parameters.AddWithValue("@NombreEstudiante", pEntidadEstudiante.NombreEstudiante);
            vlo_Command.Parameters.AddWithValue("@Apellido1Estudiante", pEntidadEstudiante.Apellido1Estudiante);
            vlo_Command.Parameters.AddWithValue("@Apellido2Estudiante", pEntidadEstudiante.Apellido2Estudiante);
            vlo_Command.Parameters.AddWithValue("@TelefonoEstudiante", pEntidadEstudiante.TelefonoEstudiante);
            vlo_Command.Parameters.AddWithValue("@CorreoEstudiante", pEntidadEstudiante.CorreoEstudiante);
            vlo_Command.Parameters.AddWithValue("@FechaIngreso", pEntidadEstudiante.FechaIngreso);
            vlo_Command.Parameters.AddWithValue("@EstadoEstudiante", pEntidadEstudiante.EstadoEstudiante);
            Sentencia = "UPDATE ESTUDIANTES SET CEDULA_ESTUDIANTE=@CedulaEstudiante,NOMBRE_ESTUDIANTE=@NombreEstudiante,PRIMER_APELLIDO_E=@Apellido1Estudiante, SEGUNDO_APELLIDO_E=@Apellido2Estudiante,TELEFONO_ESTUDIANTE=@TelefonoEstudiante, CORREO_ESTUDIANTE=@CorreoEstudiante, FECHA_INGRESO=@FechaIngreso, ESTADO_ESTUDIANTE=@EstadoEstudiante" +
                " WHERE ID_ESTUDIANTE=@Id"
;
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

        public int Eliminar(EntidadEstudianteWeb pEntidadEstudiante)
        {
            int resultado = -1;
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_command = new SqlCommand();
            string sentencia;
            vlo_command.Connection = vlo_conexion;
            vlo_command.Parameters.AddWithValue("@Id", pEntidadEstudiante.Id);
            sentencia = "DELETE FROM ESTUDIANTES WHERE ID_ESTUDIANTE=@Id";
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
            vlo_command.CommandText = "SP_ELIMINAR_ESTUDIANTE";
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
    }
}
