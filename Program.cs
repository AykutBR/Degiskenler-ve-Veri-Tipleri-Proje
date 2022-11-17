using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapilari_ve_Algoritma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# DEĞİŞKENLER


            // Değişken türü DEğişken ismi = Değer; şeklinde kullanılır.
            // Örnek: int sayi;
            //        sayi = 15;
            //  console.writeline(sayi);
            //  console.read();


            // Önemli NOTLAR!

            // Her değişkenin bir türü ve ismi vardır.
            // Değişken isimleri, büyük-küçük harf duyarlıdır. Bunları ayrı değişkenler olarak algılar.
            // Değişken adları rakamla başlamaz.
            // Aynı kod bloğu içerisindeki aynı değişken birden fazla tekrarlanamaz.
            // Değişken isimleri, işlem operatörü içeremez.


            // Veri Tipleri ve alabilecekleri değerler


            byte a = 175;  //Uzunuluğu 1 byte. 0 ile 255 arasında değer alır.
            sbyte b = -25; //Uzunluğu 1 byte. -128 ile 127 arasında değer alır.
            short c = 32;  //Uzunluğu 2 byte. -32768 ile 32767 arasında değer alır.
            ushort d = 16517; //Uzunluğu 2 byte. 0 ile 65535 arasında değer alır.
            int e = 3; //Uzunluğu 4 byte. -2.147.483.648 ile  2.147.483.648 arasında değer alır.
            long f = 48; //Uzunluğu 8 byte. -9,223,372,036,854,775,808’den 9,223,372,036,854,775,807 arasında değer alır.
            float g = 5.71F; //Uzunluğu 4 byte. 1.5E-45 ile 3.4E+38 arasında değer alır.
            double h = 7D; //Uzunluğu 8 byte. 5E-324 ile 1.7E+308 arasında değer alır.
            decimal i = 3572; //Uzunluğu 12 byte. 1E-28 ile 7.9E+28 arasında değer alır.

             string text = "Metinsel ifadeler";  //Metinsel değerler için kullanılır.
             char text1 = 'A'; //Sadece bir tane harfi temsil etmek için kullanılır.
             bool islem= 71<65; //True-False değer tutan tiptir.
             bool islemI = 92 > 715; 

            
            // Datetime 

            DateTime bugün = DateTime.Now;
            Console.WriteLine("Uygulamayı Çalıştırdığın Gün: " + bugün);
            Console.Read();


            
             
          




        }
    }
}
