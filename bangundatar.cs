using System;

namespace QUIZ09092019
{
    class bangundatar
    {
        public void  luas_persegi()
        {
            Console.WriteLine("Luas Persegi");

            int sisi, luas;

            Console.Write("Sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Luas Persegi = "+luas);
        }
        public void luas_segitiga()
        {
            Console.WriteLine("Luas segitiga");

            int alas, tinggi, luas;

            Console.Write("Alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi /2;

            Console.WriteLine("Luas segitiga = "+luas);
        }
            public void luas_lingkaran(){

            Console.WriteLine("Menghitung Luas Lingkaran");
            int jari, luas;

            Console.Write("jari =");
            jari = Convert.ToInt32(Console.ReadLine());

            luas = 22 * jari * jari /7;

            Console.WriteLine("luas lingkaran = "+luas);
        }
    }
}

