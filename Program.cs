using System;

namespace ResponsiPemrograman2904
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("reja", 19112904, 23000);
            karyawan.GetNameAndNikAndGajiBulanan();
            karyawan.GajiNaik();
            Karyawan karyawan2 = new Karyawan("vicky", 11111111, 23000);
            karyawan2.GetNameAndNikAndGajiBulanan();
            karyawan2.GajiNaik();
        }
    }
}
