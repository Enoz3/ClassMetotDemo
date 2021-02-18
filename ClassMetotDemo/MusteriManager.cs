using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle() 
        {
            Console.WriteLine("Müşteri eklendi.");
        }
        public void MusteriSilme()
        {
            Console.WriteLine("Müşteri silindi.");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler:");
            foreach (Musteri siralama in musteriler)
            {
                Console.WriteLine(siralama.Adi);
            }
        }
    }
}
