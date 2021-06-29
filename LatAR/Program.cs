using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatAR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNama = { "erick", "wely", "sony" };

            Console.WriteLine(arrNama[2].ToString() + "\n");

            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }
            Console.WriteLine();

            foreach (string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();

            int[] arrBil = new int[3];

            arrBil[0] = 75;
            arrBil[1] = 80;
            arrBil[2] = 95;


            foreach (int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }


            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i], arrBil);
            }

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
