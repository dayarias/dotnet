using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace EtapaUno {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");
            //escuela.Pais ="Colombia";
            //escuela.Ciudad="Bogota";

            //Collections   
            escuela.Cursos = new List<Curso> () {
                new Curso () { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "301", Jornada = TiposJornada.Mañana },
            };

            var otraColeccion= new List<Curso> () {
                new Curso () { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso () { Nombre = "502", Jornada = TiposJornada.Tarde },
            };

            escuela.Cursos.Add (new Curso () { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add (new Curso () { Nombre = "202", Jornada = TiposJornada.Tarde });
            //Agrega Rangos
            //otraColeccion.Clear();  //Con esta se elimina todo lo que tenga la lista otracoleccion.
            escuela.Cursos.AddRange(otraColeccion);

            Curso tmp = (new Curso () { Nombre = "101-Vacacional", Jornada = TiposJornada.Noche });
            
            ImprimirCursosEscuela (escuela);
           
            //Elimina la coleccion completa
            //otraColeccion.Clear();  

            //Como borrar elementos teniendo el hashcode anterior en memoria
            //escuela.Cursos.Add (tmp);
            //WriteLine("Curso.hash" + tmp.GetHashCode());
            //escuela.Cursos.Remove(tmp);

            //Como borrar elementos sin tener el hashcode anterior
            Predicate <Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(miAlgoritmo);
        
            ImprimirCursosEscuela (escuela);

        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre =="301";
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

        private static void ImprimirCursosForEach (Curso[] arregloCursos) {
            foreach (var curso in arregloCursos) {
                WriteLine ($"Nombre {curso.Nombre}, id {curso.UniqueId}");
            }
        }

        private static void ImprimirCursosFor (Curso[] arregloCursos) {
            for (int i = 0; i < arregloCursos.Length; i++) {
                WriteLine ($"Nombre {arregloCursos[i].Nombre}, id{arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosDoWhile (Curso[] arregloCursos) {
            int contador = 0;
            do {
                WriteLine ($"Nombre {arregloCursos[contador].Nombre}, id{arregloCursos[contador].UniqueId}");
                contador++;
            }
            while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosWhile (Curso[] arregloCursos) {
            int contador = 0;
            while (contador < arregloCursos.Length) {
                WriteLine ($"Nombre {arregloCursos[contador].Nombre}, id{arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        /*Impresion con arreglo pero con errores
        System.WriteLine(arregloCursos[0].Nombre);
        WriteLine("Presione ENTER para continuar");
        ReadLine();
        System.WriteLine(arregloCursos[5].Nombre);
         */
        /* Impresion sin arreglo
        WriteLine(curso1.Nombre + ","+ curso1.UniqueId);
        WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
        System.WriteLine(curso3);
        */

    }

}