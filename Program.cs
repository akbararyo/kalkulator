using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih menu calculator:\n\n");
            Console.WriteLine("1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
            Console.WriteLine("Input nomor menu [1..4]: ");
            int pilih = int.Parse(Console.ReadLine());
            Console.WriteLine("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            if (pilih == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilih == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilih == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (pilih == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("maaf angka yg Anda inputkan salah!!");
            }

            
            Console.WriteLine("\nTekan sembarang u/ keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
