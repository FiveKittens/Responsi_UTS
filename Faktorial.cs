using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_PreUTS
{
    class Faktorial : Bilangan
    {
        public int fakt;
        private int i;
        public void Hasil()
        {
            fakt = 1;
            Console.Write("Masukkan Angka = ");
            SetAngka(int.Parse(Console.ReadLine()));
            Console.Write("Faktorial dari " + GetAngka() + "! = ");
            for(i = GetAngka(); i > 0 ; i--)
            {

                Console.Write(i + "x");
                fakt = fakt * i;
            }
            Console.Write("\b = " + fakt);
        }
    }
}
