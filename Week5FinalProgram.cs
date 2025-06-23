

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Week5Final;
using Car = Week5Final.Car;
class Program
{
    static void Main()
    {
    giris:
        Console.WriteLine("Araba üretmek istiyor musunuz ?(E/H)");
        string cevap = Console.ReadLine();
        cevap = cevap.Trim().ToUpper();
        List<Car> arabalar = new List<Car>();

        if (cevap == "E")
        {
        newCar1:
            Car newCar = new Car();
            newCar.UretimTarihi = DateTime.Now;
            Console.Write("Seri No:");
            newCar.SeriNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marka:");
            newCar.Marka = Console.ReadLine();
            Console.Write("Model:");
            newCar.Model = Console.ReadLine();
            Console.Write("Renk:");
            newCar.Renk = Console.ReadLine();
        kapiSayi:
            Console.Write("Kapı Sayısı:");
            string kapiGiris1 = Console.ReadLine();
            if (int.TryParse(kapiGiris1, out int kapiSayi))
            {
                newCar.KapiSayisi = kapiSayi;
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir kapı sayısı giriniz.");
                goto kapiSayi;
            }
            arabalar.Add(newCar);
            Console.WriteLine("Başka araba üretmek istiyor musunuz ?(E/H)");
        cevap2Giris:
            string cevap2 = Console.ReadLine();
            cevap2 = cevap2.Trim().ToUpper();
            if (cevap2 == "E")
            {
                goto newCar1;
            }
            else if (cevap2 == "H")
            {
                Console.WriteLine("\n------- ÜRETİLEN ARAÇLAR -------");
                foreach (var car in arabalar)
                {
                    Console.WriteLine($"Seri NO: {car.SeriNo} , Marka: {car.Marka}");
                }
            }
            else
            {
                Console.WriteLine("Lütfen E veya H harflerinden birini giriniz.");
                goto cevap2Giris;
            }
        }
        else if (cevap == "H")
        {
            Console.WriteLine("Programdan çıkılıyor...");
        }
        else
        {
            Console.WriteLine("Lütfen E veya H harflerinden birini giriniz.");
            goto giris;
        }
    }
}

