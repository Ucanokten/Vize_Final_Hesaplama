using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Final_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, vizesonuc, finalsonuc, ortalama; //veri isimlerine değişken atıyoruz
            int giris, numara; 
            string ogrenci;

            Console.Write("Giriş Yapılacak Öğrenci Sayısı = ");
            giris = Convert.ToInt32(Console.ReadLine());
            string[] gosterge = new string[giris]; //dizi oluşturup verileri çekiyoruz,
            for (int i = 0; i < giris; i++)
            {
                Console.WriteLine();
                Console.Write("Öğrenci Adı Giriniz = ");
                ogrenci = Convert.ToString(Console.ReadLine());   //Verileri istediğimiz şekilde dönüştürüyoruz
                Console.Write("Öğrenci Numarasını Giriniz = ");
                numara = Convert.ToInt32(Console.ReadLine());     
                Console.Write("Vize Notunu Giriniz = ");
                vize = Convert.ToInt16(Console.ReadLine());
                Console.Write("Final Notunu Giriniz = ");
                final = Convert.ToInt16(Console.ReadLine());

                //Ortalama için matematiksel işlemleri belirliyoruz
                vizesonuc = vize * 0.4;
                finalsonuc = final * 0.6;
                ortalama = vizesonuc + finalsonuc;

                if (final < 50)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz FF (Kaldınız) ");
                }

                else if(ortalama >= 92 && ortalama <= 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz AA (Geçtiniz) ");
                }

                else if (ortalama >= 82 && ortalama <= 91)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz BA (Geçtiniz) ");
                }

                else if (ortalama >= 73 && ortalama <= 81)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz BB (Geçtiniz) ");
                }

                else if (ortalama >= 64 && ortalama <= 72)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz CB (Geçtiniz) ");
                }

                else if (ortalama >= 55 && ortalama <= 63)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz CC (Geçtiniz) ");
                }

                else if (ortalama >= 48 && ortalama <= 54)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz DC (Bu Dersten Şartlı Olarak Geçtiniz) ");
                }

                else if (ortalama >= 40 && ortalama <= 47)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz DD (Bu Dersten Şartlı Olarak Geçtiniz) ");
                }

                else if (ortalama >= 0 && ortalama <= 39)
                {
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Adı = " + ogrenci);
                    Console.WriteLine("Öğrenci Numarası = " + numara);
                    Console.WriteLine("Ortalamanız = " + ortalama + " Harf Notunuz FF (Kaldınız) ");
                }

            }

            Console.ReadKey();

        
        }

  }
}
