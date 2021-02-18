using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri() { Id = 1001, Adi = "Ahmet Yılmaz", Bakiye = 48384 };
            Musteri musteri2 = new Musteri() { Id = 1002, Adi = "Kemal Yıldırım",Bakiye = 5768 };
            Musteri musteri3 = new Musteri() { Id = 1003, Adi = "Ali Demir", Bakiye = 126539 };
            Musteri musteri4 = new Musteri() { Id = 1004, Adi = "Ayşe Yıldız", Bakiye = 10376 };
            Musteri musteri5 = new Musteri() { Id = 1005, Adi = "Fatma Şimşek", Bakiye = 398654 };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,
            musteri4, musteri5};

            MusteriManager musteriManager = new MusteriManager();

            bool dongu = true;

            while (dongu == true)
            {

                Console.WriteLine("Tercihiniz nedir? \n 1- Musteri ekle \n 2- Musteri sil \n 3- Musteri listele");
                int tercih = Convert.ToInt32(Console.ReadLine());

                if (tercih == 1)
                {
                    musteriManager.MusteriEkle();
                    Console.WriteLine("Çıkmak ister misiniz? (Evet-Hayır)");
                    int cikis = Convert.ToInt32(Console.ReadLine());
                    if (cikis == 1)
                    {
                        dongu = false;
                        Console.WriteLine("Çıktınız.");
                    }
                    else if (cikis == 2) 
                    {
                        Console.WriteLine("Çıkış yapmadınız."); 
                    }
                    else { Console.WriteLine("Anlayamadım tekrar tercihinizi yazabilir misisniz? (1 veya 2)"); }

                }
                else if (tercih == 2)
                {
                    musteriManager.MusteriSilme();
                    Console.WriteLine("Çıkmak ister misiniz? (Evet-Hayır)");
                    int cikis = Convert.ToInt32(Console.ReadLine());
                    if (cikis == 1)
                    {
                        dongu = false;
                        Console.WriteLine("Çıktınız.");
                    }
                    else if (cikis == 2)
                    {
                        Console.WriteLine("Çıkış yapmadınız.");
                    }
                    else { Console.WriteLine("Anlayamadım tekrar tercihinizi yazabilir misisniz? (1 veya 2)"); }
                }
                else if (tercih == 3)
                {
                    musteriManager.MusteriListele(musteriler);
                    Console.WriteLine("Çıkmak ister misiniz? (1 = Evet, 2 = Hayır)");
                    int cikis = Convert.ToInt32(Console.ReadLine());
                    if (cikis == 1)
                    {
                        dongu = false;
                        Console.WriteLine("Çıktınız.");
                    }
                    else if (cikis == 2)
                    {
                        Console.WriteLine("Çıkış yapmadınız.");
                    }
                    else { Console.WriteLine("Anlayamadım tekrar tercihinizi yazabilir misisniz? (1 veya 2)"); }
                }
                else
                {
                    Console.WriteLine("Çıkmak ister misiniz? (Evet-Hayır)");
                    int cikis = Convert.ToInt32(Console.ReadLine());
                    if (cikis == 1)
                    {
                        dongu = false;
                        Console.WriteLine("Çıktınız.");
                    }
                    else if (cikis == 2)
                    {
                        Console.WriteLine("Çıkış yapmadınız.");
                    }
                    else { Console.WriteLine("Anlayamadım tekrar tercihinizi yazabilir misisniz? (1 veya 2)"); }
                    Console.WriteLine("Anlayamadım tekrar tercihinizi yazabilir misisniz? (1, 2 veya 3)");
                }
            }
        }
    }

}
