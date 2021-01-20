using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Handan";
            musteri1.MusteriSoyadi = "Alper";
            

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Selim";
            musteri2.MusteriSoyadi = "Yüksel";
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine("-----------");
                   
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);            
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri2);


        }
    }
}
