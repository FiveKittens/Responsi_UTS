using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_PreUTS
{
    class DeretAngka : Bilangan
    {
        private int i, j;
        public int deret;
        public void Hasil()
        {
            Console.Write("Masukkan Angka = ");
            SetAngka(int.Parse(Console.ReadLine()));
            deret = 1;
            Console.Write("Deret = " + deret +",");
            for (i = 1; i < GetAngka(); i++)
            {
                deret = deret * 3;
                Console.Write(deret + ",");
            }
            Console.Write("\b\b\b");
        }
    }
}
