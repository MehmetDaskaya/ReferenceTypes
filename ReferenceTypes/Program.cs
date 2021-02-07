using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean ----> value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("sayı 1: "+ sayi1); // 20 yazdıracak çünkü sayı2'nin ilk değerini aldı.

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------"); 

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 250;

            Console.WriteLine("sayilar1[0] = " + sayilar1[0]); // sayilar1'in 0. indexteki sayısı sayilar2'nin 0. indexteki sayısına eşit olacak çünkü heapte aynı değeri gösteriyorlar.


        }
    }
}
