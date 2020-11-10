using System;

namespace DaLetteraASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci una lettera di cui vuoi sapere in numero in ASCII");
            char carattere = Convert.ToChar(Console.ReadLine());
            ushort carattereInAscii = 0;
            carattereInAscii = carattere;
            Console.WriteLine($"Carattere {carattere} - Carattere in ASCII {carattereInAscii}" );
        }
    }
}
