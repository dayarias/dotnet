using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace EtapaUno {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");
            //escuela.Pais ="Colombia";
            //escuela.Ciudad="Bogota";

            Curso[] arregloCursos = {
                new Curso () { Nombre = "101" },
                new Curso () { Nombre = "201" },
                new Curso () { Nombre = "301" },
            };

            escuela.Cursos = new Curso[] {
                new Curso () { Nombre = "101" },
                new Curso () { Nombre = "201" },
                new Curso () { Nombre = "301" }
            };

            /* Sin Arreglos
                        var curso2= new Curso(){
                        Nombre ="201"
                        };

                        var curso3= new Curso(){
                          Nombre ="301"
                        };
             */
            WriteLine (escuela);
            WriteLine ("------While---------");
            ImprimirCursosWhile (arregloCursos);
            WriteLine ("------DoWhile---------");
            ImprimirCursosDoWhile (arregloCursos);
            WriteLine ("--------For----------");
            ImprimirCursosFor (arregloCursos);
            WriteLine ("--------ForEach----------");
            ImprimirCursosForEach (arregloCursos);
            ImprimirCursosEscuela (escuela);

            bool rta = 10 == 10;
            int cantidad = 10;

            if (rta == false ) {
                WriteLine ("Se cumple la condicion 1");
            } else if (cantidad > 15) {
                WriteLine ("Se cumple la condicion 2");
            } else {
                WriteLine ("No se cumplio la condicion");
            }

            // Y
            if  (cantidad > 5  && rta == false)
            {
               WriteLine ("Se cumple la condicion 3"); 
            }
            //OR
            if  (cantidad > 5  || rta)
            {
               WriteLine ("Se cumple la condicion 4"); 
            }
            // Not Equal
             if  (cantidad > 5  != rta)
            {
               WriteLine ("Se cumple la condicion 5"); 
            }

            cantidad = 10;
                // Comparaciones compuestas
             if ((cantidad > 15  || !rta) && (cantidad % 5 == 0))
            {
               WriteLine ("Se cumple la condicion 6"); 
            }

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