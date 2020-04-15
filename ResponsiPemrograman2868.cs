using System;

namespace ResponsiPemrograman2868
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112868, "Hadi", 30000000);
            Karyawan karyawan2 = new Karyawan(19112868, "Huda", 2000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asyiiiik kenaikan gaji 10%!");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.gn();
            karyawan2.gn();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gb { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if(gaji < 0)
            {
                this.gb = 0;
            } else
            {
                this.gb = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gb);
        }

        public void gn()
        {
            double tmp = 0;
            tmp =  0.1 * gb;
            gb += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gb);
        }
    }
}