using static System.Console;

namespace ColegioConsole.Utils
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }
        public static void WriteTitle(string titulo)
        {
            var tam =titulo.Length +4;
            DibujarLinea (tam);
            WriteLine($" | {titulo} |");
            DibujarLinea (tam);
        }
        public static void Timbre(int hz =2000, int tiempo = 500,int cantidad = 1)
        {
       while (cantidad -- > 0)
       {
           System.Console.Beep(hz,tiempo);
       }
        }
    }
}
