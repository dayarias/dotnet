using System.Collections.Generic;
using ColegioConsole.Entidades;

namespace ColegioConsole {
    public class EscuelaEEngine {
        public Escuela Escuela { get; set; }

        public EscuelaEEngine () {

        }
        public void Inicializar ()
        {
            Escuela = new Escuela ("Platzi Academy",2012,TiposEscuela.Primaria,ciudad: "Bogotá");
            Escuela.Cursos = new List<Curso> () {
                new Curso () { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso () { Nombre = "501", Jornada = TiposJornada.Tarde },
            };
        }
    }
}