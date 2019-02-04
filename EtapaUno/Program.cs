using System;
using CoreEscuela.Entidades;

namespace EtapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela= new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogotá");
            //escuela.Pais ="Colombia";
            //escuela.Ciudad="Bogota";
            var arregloCursos = new Curso[3];

            arregloCursos[0]= new Curso(){
              Nombre ="101"
            };

            arregloCursos[1]= new Curso(){ 
                 Nombre ="201"
            };

            arregloCursos[2]= new Curso(){ 
                 Nombre ="301"
            };



/* Sin Arreglos
            var curso2= new Curso(){
            Nombre ="201"
            };

            var curso3= new Curso(){
              Nombre ="301"
            };
 */
            Console.WriteLine(escuela);
            System.Console.WriteLine("---------------");
            ImprimirCursos(arregloCursos);
        }
            private static void ImprimirCursosWhile( Curso [] arregloCursos)
            {
                int contador = 0;
                while (contador < arregloCursos.Length)
                {
                    Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, id{arregloCursos[contador].UniqueId}");
                    contador ++;
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

