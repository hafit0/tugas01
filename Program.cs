
using System;

namespace pertemuan_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculator";
            int a, b,input;

            Console.WriteLine("pilih menu calculator : \n");

            Console.WriteLine("1. Pertambahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian ");
            Console.WriteLine("\nmasukkan pilihan :");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka pertama :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua :");
            b = Convert.ToInt32(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("hasil penambahan  {0} + {1} = {2} ", a, b, penambahan(a, b));
                    Console.WriteLine("\n tekan enter untuk keluar");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("hasil pengurangan  {0} - {1} = {2} ", a, b, pengurangan(a, b));
                    Console.WriteLine("\n tekan enter untuk keluar");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("hasil perkalian  {0} * {1} = {2} ", a, b, perkalian(a, b));
                    Console.WriteLine("\n tekan enter untuk keluar");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("hasil pembagian  {0} / {1} = {2} ", a, b, pembagian(a, b));
                    Console.WriteLine("\n tekan enter untuk keluar");
                    Console.ReadKey();
                    break;
                default :
                    Console.WriteLine("\nMaaf, menu yang anda pilih tidak ada");
                    Console.WriteLine("\n tekan enter untuk keluar");
                    Console.ReadKey();
                    break;
            }


        }


        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static float pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
