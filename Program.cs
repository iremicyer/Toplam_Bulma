using System;

namespace Toplam_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Bir sayi girinzi:");
                double sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            
            }
            Console.Write( "sayilarin toplami:" + toplam );
            //Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
