using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabetic_order
{
    class Alphabets
    { 
        private static void TukarHuruf(ref char first, ref char sec)
        {
            if (first == sec)
                return;
            var counter = first;
            first = sec;
            sec = counter;
        }
        private static void HasilPermutasiInput(char[] list, int cekfirst, int ceksec)
        {
            if (cekfirst == ceksec)
                Console.WriteLine(list);
            else
                for (int hasilPermutasi = cekfirst; hasilPermutasi <= ceksec; hasilPermutasi++)
                {
                    TukarHuruf(ref list[cekfirst], ref
                   list[hasilPermutasi]);
                    HasilPermutasiInput(list, cekfirst + 1,
                   ceksec);
                    TukarHuruf(ref list[cekfirst], ref
                   list[hasilPermutasi]);
                }
        }
        public static void HasilPermutasiInput(char[] list)
        {
            int x = list.Length - 1;
            HasilPermutasiInput(list, 0, x);
        }
        static void Main(string[] args)
        {
            Console.Title = "Praktikum Week 15";
            while (true)
            {
                Console.Write("Masukkan input : ");
                string letter = Console.ReadLine();
                letter = String.Concat(letter.Split(','));
                char[] hasilInput = letter.ToCharArray();
                if (hasilInput.Length != hasilInput.Distinct().Count())
                    Console.WriteLine("HURUF ADA YANG KEMBAR\n");
                else
                {
                    HasilPermutasiInput(hasilInput);
                    Console.Write("\n");
                }
            }
        }
    }

}


      
