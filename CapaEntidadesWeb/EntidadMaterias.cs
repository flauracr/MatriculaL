using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesWeb
{
    public class EntidadMaterias
    {
        //atrubutos
        private int idMateria;
        private string codMateria;
        private string nombreMateria;
        private int horasTotales;
        private bool existeRegistro;

        //constructor vacio
        public EntidadMaterias()
        {
            idMateria = 0;
            codMateria = string.Empty;
            nombreMateria = string.Empty;
            horasTotales = 0;
            existeRegistro = false;
        }

        //sobrecarga de constructor
        public EntidadMaterias(int pid, string pcodMateria, string pnombreMateria, int phorasTotales, bool pexiste)
        {
            idMateria = pid;
            codMateria = pcodMateria;
            nombreMateria = pnombreMateria;
            horasTotales = phorasTotales;
            existeRegistro = pexiste;
        }

        //propiedades
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string CodMateria { get => codMateria; set => codMateria = value; }
        public string NombreMatertia { get => nombreMateria; set => nombreMateria = value; }
        public int HorasTotales { get => horasTotales; set => horasTotales = value; }
        public bool ExisteRegistro { get => existeRegistro; set => existeRegistro = value; }
    }
}
