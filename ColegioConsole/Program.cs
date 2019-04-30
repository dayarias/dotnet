using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using ColegioConsole.Entidades;
using ColegioConsole.Utils;
using static System.Console;

namespace ColegioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEEngine();
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela" );
            Printer.Timbre(10000,cantidad:10);
            ImprimirCursosEscuela(engine.Escuela);

        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId}");
                }
            }
            Printer.DibujarLinea(50);
        }
    }
}