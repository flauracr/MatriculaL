using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadEstudiante
    {

        //atrubutos
        private int id_Estudiante;
        private string cedulaEstudiante;
        private string nombreEstudiante;
        private string apellido1Estudiante;
        private string apellido2Estudiante;
        private string telefonoEstudiante;
        private string correoEstudiante;
        private string fechaIngreso_Estudiante;
        private string estadoEstudiante;
        private bool existeRegistro;

        //constructor vacio
        public EntidadEstudiante()
        {
            id_Estudiante = 0;
            cedulaEstudiante = string.Empty;
            nombreEstudiante = string.Empty;
            apellido1Estudiante = string.Empty;
            apellido2Estudiante = string.Empty;
            telefonoEstudiante = string.Empty;
            correoEstudiante = string.Empty;
            fechaIngreso_Estudiante = string.Empty;
            estadoEstudiante = string.Empty;
            existeRegistro = false;
        }

        public EntidadEstudiante(int pid, string pcedula, string nombreEstudiante, string papellido1, string papellido2, string ptelefono,
            string pcorreo, string pfechaI, string pestadoEstudiante, bool pexiste)
        {
            id_Estudiante = pid;
            cedulaEstudiante = pcedula;
            this.nombreEstudiante = nombreEstudiante;
            apellido1Estudiante = papellido1;
            apellido2Estudiante = papellido2;
            correoEstudiante = pcorreo;
            telefonoEstudiante = ptelefono;
            fechaIngreso_Estudiante = pfechaI;
            estadoEstudiante = pestadoEstudiante;
            existeRegistro = pexiste;
        }

        //propiedades
        public int Id { get => id_Estudiante; set => id_Estudiante = value; }
        public string CedulaEstudiante { get => cedulaEstudiante; set => cedulaEstudiante = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string Apellido1Estudiante { get => apellido1Estudiante; set => apellido1Estudiante = value; }
        public string Apellido2Estudiante { get => apellido2Estudiante; set => apellido2Estudiante = value; }
        public string CorreoEstudiante { get => correoEstudiante; set => correoEstudiante = value; }
        public string TelefonoEstudiante { get => telefonoEstudiante; set => telefonoEstudiante = value; }
        public string FechaIngreso { get => fechaIngreso_Estudiante; set => fechaIngreso_Estudiante = value; }
        public string EstadoEstudiante { get => estadoEstudiante; set => estadoEstudiante = value; }
        public bool ExisteRegistro { get => existeRegistro; set => existeRegistro = value; }
    }//clase
}//namespace


