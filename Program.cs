using System;

namespace Zahlensysteme_4BEL_Gruppe_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Umrechnung_in_Basis_16(String str_Binaer)
        {
            Console.WriteLine("Hex:" + String.Format("{0:X2}", Convert.ToUInt64(str_Binaer, 2)));
        }
    }
}
