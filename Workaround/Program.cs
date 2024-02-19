using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer();
            SelamVer();
            SelamVer();

            int sonuc = Topla();

            Console.ReadKey();
        }

        //methot 
        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
        static int Topla()
        {
            return 5;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000; //db den gelir 
            int sayi1 = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.10);
            Console.WriteLine(tutar * 1.10);
        }
    }
    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}
