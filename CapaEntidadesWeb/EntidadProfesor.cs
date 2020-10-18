using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesWeb
{
    public class EntidadProfesor
    {
        //atrubutos

        private int id_Profesor;
        private string cedulaProfesor;
        private string nombreProfesor;
        private string apellido1Profesor;
        private string apellido2Profesor;
        private string telefonoProfesor;
        private string correoProfesor;
        private string fechaIngreso_Profesor;
        private string estadoProfesor;
        private bool existeRegistro;


        //constructor vacio
        public EntidadProfesor()
        {

            id_Profesor = 0;
            cedulaProfesor = string.Empty;
            nombreProfesor = string.Empty;
            apellido1Profesor = string.Empty;
            apellido2Profesor = string.Empty;
            telefonoProfesor = string.Empty;
            correoProfesor = string.Empty;
            fechaIngreso_Profesor = string.Empty;
            estadoProfesor = string.Empty;
            existeRegistro = false;
        }

        //sobrecarga de constructor

        //sobrecarga de constructor
        public EntidadProfesor(int pid, string pcedula, string nombreProfesor, string papellido1P, string papellido2P, string ptelefonoP,
            string pcorreoP, string pfechaIP, string pestadoProfesor, bool pexisteP)
        {
            id_Profesor = pid;
            cedulaProfesor = pcedula;
            this.nombreProfesor = nombreProfesor;
            apellido1Profesor = papellido1P;
            apellido2Profesor = papellido2P;
            correoProfesor = pcorreoP;
            telefonoProfesor = ptelefonoP;
            fechaIngreso_Profesor = pfechaIP;
            estadoProfesor = pestadoProfesor;
            existeRegistro = pexisteP;


        }

        //propiedades
        public int Id { get => id_Profesor; set => id_Profesor = value; }
        public string CedulaProfesor { get => cedulaProfesor; set => cedulaProfesor = value; }
        public string NombreProfesor { get => nombreProfesor; set => nombreProfesor = value; }
        public string Apellido1Profesor { get => apellido1Profesor; set => apellido1Profesor = value; }
        public string Apellido2Profesor { get => apellido2Profesor; set => apellido2Profesor = value; }
        public string CorreoProfesor { get => correoProfesor; set => correoProfesor = value; }
        public string TelefonoProfesor { get => telefonoProfesor; set => telefonoProfesor = value; }
        public string FechaIngreso_Profesor { get => fechaIngreso_Profesor; set => fechaIngreso_Profesor = value; }
        public string EstadoProfesor { get => estadoProfesor; set => estadoProfesor = value; }
        public bool ExisteRegistro { get => existeRegistro; set => existeRegistro = value; }
    }
}
