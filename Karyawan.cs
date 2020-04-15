using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2904
{
    public class Karyawan
    {
        public Karyawan(string name, int nik, int gajibulanan)
        {
            Name = name;
            Nik = nik;
            GajiBulanan = gajibulanan;


        }
        public string Name { get; set; }
        public int Nik { get; set; }
        public int GajiBulanan { get; set; }


        public void GetNameAndNikAndGajiBulanan()
        {
            Console.WriteLine("Nama : {0} Nik : {1} Gaji Bulanan : {2}", Name, Nik, GajiBulanan);
        }

        public void GajiNaik()
        {
            Console.WriteLine("yee gaji naik 10%");
            Console.WriteLine("Nama : {0} Nik : {1} Gaji Bulanan : {2}", Name, Nik, GajiBulanan+(GajiBulanan*10 / 100));
        }
    }
}
