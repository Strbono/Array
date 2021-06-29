using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.NIM = 1234;
            mhs1.Nama = "Erik";
            mhs1.Nilai = 75;

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.NIM = 1235;
            mhs2.Nama = "wely";
            mhs2.Nilai = 80;

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.NIM = 1235;
            mhs3.Nama = "sony";
            mhs3.Nilai = 95;

            Mahasiswa[] armhs = new Mahasiswa[3];

            armhs[0] = mhs1;
            armhs[1] = mhs2;
            armhs[2] = mhs3;


            Console.WriteLine("No. NIM  Nama  Nilai");
            Console.WriteLine("---------------------------");

            int no = 1;

            foreach (Mahasiswa mhs in armhs)
            {
                Console.WriteLine($"{no++} {mhs.NIM} {mhs.Nama} {mhs.Nama} {mhs.Nilai} ");
            }

            Console.ReadKey();



            /*Console.WriteLine("No. NIM  Nama  Nilai");
            Console.WriteLine("---------------------------"); 
            Console.WriteLine("1. {0} {1} {2}", mhs1.NIM, mhs1.Nama, mhs1.Nilai);
            Console.WriteLine("1. {0} {1} {2}", mhs2.NIM, mhs2.Nama, mhs2.Nilai);
            Console.WriteLine("1. {0} {1} {2}", mhs3.NIM, mhs3.Nama, mhs3.Nilai);
            */
        }
    }
}
