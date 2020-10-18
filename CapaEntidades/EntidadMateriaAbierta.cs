using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class EntidadMateriaAbierta
    {
        //atrubutos
        private int idMateriaAbierta;
        private int idMateria;
        private string cedulaProfesor;
        private int grupo;
        private int cupo;
        private string anio;

        //constructor vacio
        public EntidadMateriaAbierta()
        {
            idMateriaAbierta = 0;
            idMateria = 0;
            cedulaProfesor = string.Empty;
            grupo = 0;
            cupo = 0;
            anio = string.Empty;
        }

        //sobrecarga de constructor
        public EntidadMateriaAbierta(int pid, int pidMateria, string pcedulaprofesor, int pgrupo, int pcupo, string panio)
        {
            idMateriaAbierta = pid;
            idMateria = pidMateria;
            cedulaProfesor = pcedulaprofesor;
            grupo = pgrupo;
            cupo = pcupo;
            anio = panio;
        }

        //propiedades
        public int IdMateriaAbierta { get => idMateriaAbierta; set => idMateriaAbierta = value; }
        public string IdMateria { get => IdMateria; set => IdMateria = value; }
        public string CedulaProfesor { get => cedulaProfesor; set => cedulaProfesor = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public string Anio { get => anio; set => anio = value; }

    }//clase
}//namespace
