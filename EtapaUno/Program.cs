using System;
using CoreEscuela.Entidades;

namespace EtapaUno {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela ("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");
            //escuela.Pais ="Colombia";
            //escuela.Ciudad="Bogota";
            Curso [] arregloCursos =  {
                new Curso () { Nombre = "101" },
                new Curso () { Nombre = "201" };
                new Curso () { Nombre = "301" };


            /* Sin Arreglos
                        var curso2= new Curso(){
                        Nombre ="201"
                        };

                        var curso3= new Curso(){
                          Nombre ="301"
                        };
             */
            Console.WriteLine (escuela);
            System.Console.WriteLine ("------While---------");
            ImprimirCursosWhile (arregloCursos);
            System.Console.WriteLine ("------DoWhile---------");
            ImprimirCursosDoWhile (arregloCursos);
            System.Console.WriteLine ("--------For----------");
            ImprimirCursosFor (arregloCursos);
            System.Console.WriteLine ("--------ForEach----------");
            ImprimirCursosForEach (arregloCursos);

        }
        private static void ImprimirCursosForEach (Curso[] arregloCursos) {
            foreach (var curso in arregloCursos) {
                Console.WriteLine ($"Nombre {curso.Nombre}, id {curso.UniqueId}");
            }
        }

        private static void ImprimirCursosFor (Curso[] arregloCursos) {
            for (int i = 0; i < arregloCursos.Length; i++) {
                Console.WriteLine ($"Nombre {arregloCursos[i].Nombre}, id{arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosDoWhile (Curso[] arregloCursos) {
            int contador = 0;
            do {
                Console.WriteLine ($"Nombre {arregloCursos[contador].Nombre}, id{arregloCursos[contador].UniqueId}");
                contador++;
            }
            while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosWhile (Curso[] arregloCursos) {
            int contador = 0;
            while (contador < arregloCursos.Length) {
                Console.WriteLine ($"Nombre {arregloCursos[contador].Nombre}, id{arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        /*Impresion con arreglo pero con errores
        System.Console.WriteLine(arregloCursos[0].Nombre);
        Console.WriteLine("Presione ENTER para continuar");
        Console.ReadLine();
        System.Console.WriteLine(arregloCursos[5].Nombre);
         */
        /* Impresion sin arreglo
        Console.WriteLine(curso1.Nombre + ","+ curso1.UniqueId);
        Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
        System.Console.WriteLine(curso3);
        */
    }
}