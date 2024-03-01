using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkSpace
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Degiskenler(); ctrl-r-m ile yapılıyor

            Vatandas vatandas1 = new Vatandas();

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 12345678910;


            Person person2 = new Person();
            person2.FirstName = "Ahsen";
            person2.LastName = "Sirer";
            person2.DateOfBirthYear = 1998;
            person2.NationalIdentity = 12345678111;

            //SelamVer(isim: "Engin");
            //SelamVer(isim: "Ahsen");
            //SelamVer(isim: "Büşra");

            //SelamVer();

            //int sonuc = Topla(3, 5);

            PttManager pttManager=new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        //main içinde kullanacağımız için aşağıdaki kalıpla yazdık
        //işi yapacak kodu bloğa koyup istediğimiz yerde çağırıyoruz
        // isimsiz olan yer default parametre olarak geçiyor

        
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        //fonksiyonun dönüş tipi yani metodu int, ismi topla, 2 tane parametre, parametreleri verdiğim zaman toplama yapıp onu lokal değişkene atadım.
        //static int Topla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    Console.WriteLine("Toplam : " + sonuc);
        //    return sonuc;
        //}
    }

    //pascal casing
    public class Vatandas
    {
        //prop yazdığımızda aşağıdaki komutlar çıkıyor
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }

}
