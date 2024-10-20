using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam");


            Console.WriteLine("******** Yemek Kategorileri**********");
            Console.WriteLine();
            Console.WriteLine("1- Çorbalar");
            Console.WriteLine("2- Ana Yemekler");
            Console.WriteLine("3- Soğukk Başlangıçlar");
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçecekler");
            Console.WriteLine("******** Yemek Kategorileri**********");

            Console.ReadLine();

            #endregion

            #region String_Değişkenler

            //string
            //Değişken_türü değişken_adı;

            string name;
            name = "Tom";
            Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Isaac";
            customerSurname = "Asımov";
            customerPhone = "+90 500 000 00 01";
            customerEmail = "ısaacasım@gmail.com";
            district = "Brooklyn";
            city = "New York";



            Console.WriteLine("******* Rezervasyon kartı *******");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------------------");

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 500 000 00 02";
            customerEmail = "aysegulkaya@gmail.com";
            district = "Sapanca";
            city = "Sakarya";



            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------------------");





            #endregion

            #region Int_Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonatePrice = 30;

            Console.WriteLine("****** Restoran Menü Fiyatı *******");
            Console.WriteLine();
            Console.WriteLine("----  Kola: " + cokePrice + "TL");
            Console.WriteLine("----  Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----  Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----  Limonata: " + lemonatePrice + "TL");
            Console.WriteLine("----  Kızartma: " + friesPrice + "TL");
            Console.WriteLine("----  Su: " + waterPrice + "TL");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonateCount;

            int totalHamburgerPries = 0;
            int totalCokePries = 0;
            int totalWaterPries = 0;
            int totalFriesPries = 0;
            int totalPizzaPries = 0;
            int totalLemonatePries = 0;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonateCount = 0;

            totalHamburgerPries = hamburgerCount * hamburgerPrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPries);
            totalCokePries = cokeCount * cokePrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Kola Tutarı: " + totalCokePries);
            totalWaterPries = waterCount * waterPrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Su Tutarı: " + totalWaterPries);
            totalFriesPries = friesCount * friesPrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPries);
            totalPizzaPries = pizzaCount * pizzaPrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPries);
            totalLemonatePries = lemonateCount * lemonatePrice;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Limonata Tutarı: " + totalLemonatePries);

            Console.WriteLine();

            int totalPrice = totalHamburgerPries + totalCokePries + totalFriesPries + totalPizzaPries + totalLemonatePries;
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice);
            #endregion


            Console.ReadLine();


        }
    }
}
