using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + "Bahar isimli musteri eklendi.");
        }

        public void Listele(Musteri musteri)
        {
                Console.WriteLine("------ Listelenen müsteri-------");
                Console.WriteLine(" Id " + musteri.Id);
                Console.WriteLine("TcKimlikNo " + musteri.TcKimlikNo);
                Console.WriteLine("Adi" + musteri.Adi);
                Console.WriteLine(" Soyadi " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Bahar isimli musteri silindi.");
        }
    }
}
