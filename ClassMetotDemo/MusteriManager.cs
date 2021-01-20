using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.MusteriSoyadi + musteri.MusteriAdi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.MusteriSoyadi + musteri.MusteriAdi);
        }                         
    }
}
