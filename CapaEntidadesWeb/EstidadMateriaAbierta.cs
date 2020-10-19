namespace CapaEntidadesWeb
{
    public class EstidadMateriaAbierta
    {
        //atrubutos
        private int idMateriaAbierta;
        private int idMateria;
        private string cedulaProfesor;
        private int grupo;
        private int cupo;
        private string anio;
        private bool existeRegistro;

        //constructor vacio
        public EstidadMateriaAbierta()
        {
            idMateriaAbierta = 0;
            idMateria = 0;
            cedulaProfesor = string.Empty;
            grupo = 0;
            cupo = 0;
            anio = string.Empty;
            existeRegistro = false;
        }

        //sobrecarga de constructor
        public EstidadMateriaAbierta(int pid, int pidMateria, string pcedulaprofesor, int pgrupo, int pcupo, string panio, bool pexiste)
        {
            idMateriaAbierta = pid;
            idMateria = pidMateria;
            cedulaProfesor = pcedulaprofesor;
            grupo = pgrupo;
            cupo = pcupo;
            anio = panio;
            existeRegistro = pexiste;
        }

        //propiedades
        public int IdMateriaAbierta { get => idMateriaAbierta; set => idMateriaAbierta = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string CedulaProfesor { get => cedulaProfesor; set => cedulaProfesor = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public string Anio { get => anio; set => anio = value; }
        public bool ExisteRegistro { get => existeRegistro; set => existeRegistro = value; }
    }
}
