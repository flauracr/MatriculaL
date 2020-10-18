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
    public class ProfesorAD
    {
        private string _cadenaConexion;
        private string mensaje;
        public string Mensaje
        {
            get => mensaje;
        }
        public ProfesorAD()
        {
            mensaje = string.Empty;
            _cadenaConexion = string.Empty;
        }
        public ProfesorAD(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            mensaje = string.Empty;
        }


        public int Insertar(EntidadProfesor pEntidadProfesor)
        {
            SqlConnection vlo_sqlConexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_sqlCommand = new SqlCommand();
            int idProfesor = 0;
            string sentencia = string.Empty;
            vlo_sqlCommand.Connection = vlo_sqlConexion;
            try
            {
                sentencia = "INSERT INTO PROFESORES (CEDULA_PROFESOR, NOMBRE_PROFESOR,PRIMER_APELLIDO_P, SEGUNDO_APELLIDO_P, TELEFONO_PROFESOR, CORREO_PROFESOR) " +
                    "VALUES (@CedulaProfesor, @NombreProfesor,@PrimerApellidoP, @SegundoApellidoP, @TelefonoProfesor, @CorreoProfesor) SELECT @@Identity";
                //SCOPE_IDENTITY()
                //IDENT_CURRENT("TABLA")
                vlo_sqlCommand.Parameters.AddWithValue("@CedulaProfesor", pEntidadProfesor.CedulaProfesor);
                vlo_sqlCommand.Parameters.AddWithValue("@NombreProfesor", pEntidadProfesor.NombreProfesor);
                vlo_sqlCommand.Parameters.AddWithValue("@PrimerApellidoP", pEntidadProfesor.Apellido1Profesor);
                vlo_sqlCommand.Parameters.AddWithValue("@SegundoApellidoP", pEntidadProfesor.Apellido2Profesor);
                vlo_sqlCommand.Parameters.AddWithValue("@TelefonoProfesor", pEntidadProfesor.TelefonoProfesor);
                vlo_sqlCommand.Parameters.AddWithValue("@CorreoProfesor", pEntidadProfesor.CorreoProfesor);
                //vlo_sqlCommand.Parameters.AddWithValue("@FechaIngreso", pEntidadEstudiante.FechaIngreso);
                //vlo_sqlCommand.Parameters.AddWithValue("@EstadoEstudiante", pEntidadEstudiante.EstadoEstudiante);
                vlo_sqlCommand.CommandText = sentencia;
                vlo_sqlConexion.Open();
                idProfesor = Convert.ToInt32(vlo_sqlCommand.ExecuteScalar());
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
            return idProfesor;
        }//fin de insertar


        public DataSet ListarRegistros(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;

            string sentencia;
            try
            {
                sentencia = "Select ID_PROFESOR, CEDULA_PROFESOR, NOMBRE_PROFESOR, PRIMER_APELLIDO_P, SEGUNDO_APELLIDO_P, TELEFONO_PROFESOR, CORREO_PROFESOR from PROFESORES";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Profesores");
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }//listar registros


        public List<EntidadProfesor> ListarRegistros1(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter vlo_adapter;
            List<EntidadProfesor> Lista = new List<EntidadProfesor>();
            string sentencia;
            try
            {
                sentencia = "Select ID_PROFESOR, CEDULA_PROFESOR, NOMBRE_PROFESOR, PRIMER_APELLIDO_P, SEGUNDO_APELLIDO_P, TELEFONO_PROFESOR, CORREO_PROFESOR, FECHA_INGRESO_PROFESOR, ESTADO_PROFESOR from PROFESORES";
                if (!string.IsNullOrEmpty(condicion))
                {
                    sentencia = string.Format("{0} where {1}", sentencia, condicion);
                }
                vlo_adapter = new SqlDataAdapter(sentencia, vlo_conexion);
                vlo_adapter.Fill(DS, "Profesores");
                //sentencia linq para crear una lista a partir de un DataTable
                Lista = (from DataRow registro in DS.Tables[0].Rows
                         select new EntidadProfesor()
                         {
                             Id = (int)registro["ID_PROFESOR"],
                             CedulaProfesor = registro["CEDULA_PROFESOR"].ToString(),
                             NombreProfesor = registro["NOMBRE_PROFESOR"].ToString(),
                             Apellido1Profesor = registro["PRIMER_APELLIDO_P"].ToString(),
                             Apellido2Profesor = registro["SEGUNDO_APELLIDO_P"].ToString(),
                             TelefonoProfesor = registro["TELEFONO_PROFESOR"].ToString(),
                             CorreoProfesor = registro["CORREO_PROFESOR"].ToString(),
                             FechaIngreso_Profesor = registro["FECHA_INGRESO_PROFESOR"].ToString(),
                             EstadoProfesor = registro["ESTADO_PROFESOR"].ToString(),
                         }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }//listar registros

        public EntidadProfesor ObtenerProfesor(string condicion)
        {
            EntidadProfesor profesor = new EntidadProfesor();
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_comando = new SqlCommand();
            SqlDataReader vlo_reader;
            string sentencia;
            vlo_comando.Connection = vlo_conexion;
            sentencia = "Select ID_PROFESOR, CEDULA_PROFESOR, NOMBRE_PROFESOR, PRIMER_APELLIDO_P, SEGUNDO_APELLIDO_P, TELEFONO_PROFESOR, CORREO_PROFESOR, FECHA_INGRESO_PROFESOR, ESTADO_PROFESOR from PROFESORES";
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
                    profesor.Id = vlo_reader.GetInt32(0);
                    profesor.CedulaProfesor = vlo_reader.GetString(1);
                    profesor.NombreProfesor = vlo_reader.GetString(2);
                    profesor.Apellido1Profesor = vlo_reader.GetString(3);
                    profesor.Apellido2Profesor = vlo_reader.GetString(4);
                    profesor.TelefonoProfesor = vlo_reader.GetString(5);
                    profesor.CorreoProfesor = vlo_reader.GetString(6);
                    //profesor.FechaIngreso_Profesor = vlo_reader.GetString(7);
                    profesor.EstadoProfesor = vlo_reader.GetString(8);
                    profesor.ExisteRegistro = true;

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
            return profesor;
        }//obtener profesor

        public int Modificar(EntidadProfesor pEntidadProfesor)
        {
            int resultado = -1;
            SqlConnection vlo_Conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_Command = new SqlCommand();
            string Sentencia = string.Empty;
            vlo_Command.Connection = vlo_Conexion;
            vlo_Command.Parameters.AddWithValue("@Id", pEntidadProfesor.Id);
            vlo_Command.Parameters.AddWithValue("@CedulaProfesor", pEntidadProfesor.CedulaProfesor);
            vlo_Command.Parameters.AddWithValue("@NombreProfesor", pEntidadProfesor.NombreProfesor);
            vlo_Command.Parameters.AddWithValue("@Apellido1Profesor", pEntidadProfesor.Apellido1Profesor);
            vlo_Command.Parameters.AddWithValue("@Apellido2Profesor", pEntidadProfesor.Apellido2Profesor);
            vlo_Command.Parameters.AddWithValue("@TelefonoProfesor", pEntidadProfesor.TelefonoProfesor);
            vlo_Command.Parameters.AddWithValue("@CorreoProfesor", pEntidadProfesor.CorreoProfesor);
            //vlo_Command.Parameters.AddWithValue("@FechaIngreso_Profesor", pEntidadProfesor.FechaIngreso_Profesor);
            //vlo_Command.Parameters.AddWithValue("@EstadoProfesor", pEntidadProfesor.EstadoProfesor);
            Sentencia = "UPDATE PROFESORES SET CEDULA_PROFESOR=@CedulaProfesor,NOMBRE_PROFESOR=@NombreProfesor,PRIMER_APELLIDO_P=@Apellido1Profesor, SEGUNDO_APELLIDO_P=@Apellido2Profesor,TELEFONO_PROFESOR=@TelefonoProfesor, CORREO_PROFESOR=@CorreoProfesor" +
                " WHERE ID_PROFESOR=@Id"
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

        public int Eliminar(EntidadProfesor pEntidadProfesor)
        {
            int resultado = -1;
            SqlConnection vlo_conexion = new SqlConnection(_cadenaConexion);
            SqlCommand vlo_command = new SqlCommand();
            string sentencia;
            vlo_command.Connection = vlo_conexion;
            vlo_command.Parameters.AddWithValue("@Id", pEntidadProfesor.Id);
            sentencia = "DELETE FROM PROFESORES WHERE ID_PROFESOR=@Id";
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
            vlo_command.CommandText = "SP_ELIMINAR_PROFESOR";
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
        }//fin de eliminar
    }
}
