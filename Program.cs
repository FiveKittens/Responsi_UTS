using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_PreUTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktorial f = new Faktorial();
            DeretAngka d = new DeretAngka();
            f.Hasil();
            Console.ReadLine();
            d.Hasil();
            Console.ReadLine();
        }
    }
}
