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
            string numero = Convert.ToString(carattereInAscii, 2).PadLeft(16, '0');
            Console.WriteLine($"Carattere {carattere} - Carattere in ASCII {carattereInAscii}- NumeroBinario {numero}");

        }
    }
}
