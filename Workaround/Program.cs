using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {

        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer();

            int sonuc = Topla(3,5);

            //Diziler / Array

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);    
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[5];
            ogrenciler[0] = "Engin";
            ogrenciler[1]= "Kerem";
            ogrenciler[2]= "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //Person person1=new Person();
            //person1.FirstName = "Murat";

            //Person person2 = new Person();
            //person2.FirstName = "Murat";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            //PttManager pttManager = new PttManager(new ForeignerManager());
            //pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //methot 
        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1,int sayi2)
        {
            int sonuc= sayi1+sayi2;
            Console.WriteLine("Toplam" + sonuc);
            return sonuc;
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
