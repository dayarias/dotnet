using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using ColegioConsole.Entidades;
using static System.Console;

namespace ColegioConsole {
    class Program {
        static void Main (string[] args) {
            var engine = new EscuelaEEngine ();
            engine.Inicializar ();

            ImprimirCursosEscuela (engine.Escuela);

        }

      
        private static void ImprimirCursosEscuela (Escuela escuela) {
            WriteLine ("-----------------");
            WriteLine ("Cursos de la escuela");
            WriteLine ("-----------------");
            if (escuela?.Cursos != null) {
                foreach (var curso in escuela.Cursos) {
                    WriteLine ($"Nombre {curso.Nombre}, id {curso.UniqueId}");
                }

            }
            WriteLine ("-----------------");

        }

    }
}