using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcKimlikNo = "12345678945";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcKimlikNo = " 14567896528";
            musteri2.Adi = "Emine";
            musteri2.Soyadi = "Bülbül";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcKimlikNo = " 65855648962";
            musteri3.Adi = "Aykut";
            musteri3.Soyadi = "Öztürk";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);

        }
    }
}
