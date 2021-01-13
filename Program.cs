using System;

namespace Eğitim_Alanı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk Sayınızı Giriniz");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İlk Sayınızı Giriniz");
            double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Hangi işlemi Yapmak İstiyorsanız Lütfen Onu Yazınız");
            Console.WriteLine("1-) Topla \n 2-) Çıkar \n 3-) Çarp \n 4-) Böl \n 5-) Modunu Al");

            int islem = Convert.ToInt16(Console.ReadLine());

            double cevap;

            switch (islem)
            {



                case 1:
                    cevap = a + b;
                    Console.WriteLine(cevap);
                    break;
                case 2:
                    cevap = a - b;
                    Console.WriteLine(cevap);
                    break;
                case 3:
                    cevap = a * b;
                    Console.WriteLine(cevap);
                    break;
                case 4:
                    cevap = a / b;
                    Console.WriteLine(cevap);
                    break;
                case 5:
                    cevap = a % b;
                    Console.WriteLine(cevap);
                    break;

                default:
                    Console.WriteLine("Lütfen Doğru İşlem Numarası Girdiğinizden Emin Olun");
                    break;
            }


        }
    }
}
