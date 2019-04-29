using System;
using ColegioConsole.Entidades;

public class Curso {
        public Curso (string uniqueId, string nombre, TiposJornada jornada) {
            this.UniqueId = uniqueId;
            this.Nombre = nombre;
            this.Jornada = jornada;

        }
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Curso () => UniqueId = Guid.NewGuid ().ToString ();
    }



    