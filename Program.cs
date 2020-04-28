using System;

namespace Zahlensysteme_4BEL_Gruppe_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int BinZahl = 0;
            Console.WriteLine("Gib eine Binärzahl ein: ");
            BinZahl = Convert.ToInt32(Console.ReadLine());
        }

        static void Umrechnung_in_Basis_16(String str_Binaer)
        {
            Console.WriteLine("Hex:" + String.Format("{0:X2}", Convert.ToUInt64(str_Binaer, 2)));
        }
    }
}
