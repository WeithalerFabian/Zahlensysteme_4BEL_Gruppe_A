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

        static void U_D(String str_Binaer)
        {
            int num, binary_val, decimal_val = 0, base_val = 1, rem;            
            num = int.Parse(str_Binaer); 
            binary_val = num;

            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }            
            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);            
        }
    }
}
