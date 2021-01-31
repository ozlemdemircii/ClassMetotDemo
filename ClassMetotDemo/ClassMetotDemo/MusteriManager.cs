using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        List<Musteri> MusteriListesi;

        public MusteriManager()
        {
            MusteriListesi = new List<Musteri>();

            Initialize();
        }

        private void Initialize()
        {
            MusteriListesi.Add(new Musteri
            {
                Adi = "Ahmet",
                Id = 1,
                SoyAdi = "Yıldırım",
                Tc = "11296666666"
            });

            MusteriListesi.Add(new Musteri
            {
                Adi = "Özlem",
                Id = 2,
                SoyAdi = "Yıldırım",
                Tc = "22651232145"
            });
        }

        public void Ekle(Musteri mst)
        {

            var s = MusteriListesi.Where(o => o.Tc == mst.Tc).FirstOrDefault();

            if (s == null)
            {
                MusteriListesi.Add(mst);
            }
            else
            {
                Console.WriteLine("Hata : Bu TC numarası daha önce kullanılmış".PadLeft(30, '-'));
            }
        }

        /// <summary>
        /// Müşteri siler
        /// </summary>
        /// <param name="tc">Silinecek müşteri TC numarası</param>
        public void Sil(string tc)
        {
            var musteri = MusteriListesi.Where(o => o.Tc == tc).FirstOrDefault();

            if (musteri != null)
            {
                MusteriListesi.Remove(musteri);
            }
            else
            {
                Console.WriteLine("Hata : Bu TC numarası ile ilgili kayıt yok".PadLeft(30, '-'));
            }
        }

        public void Guncelle(Musteri mst)
        {
            var musteri = MusteriListesi.Where(o => o.Tc == mst.Tc).FirstOrDefault();

            if (musteri != null)
            {
                musteri.Adi = mst.Adi;
                musteri.SoyAdi = mst.SoyAdi;
                musteri.Tc = mst.Tc;

                Console.WriteLine($" {mst.Adi} {mst.SoyAdi} isimli kayıt güncellendi.");

            }
        }

        public void Listele()
        {
            Console.WriteLine("\n\n");

            MusteriListesi.ForEach(o =>
            {
                Console.WriteLine($"Ad - Soyad :{o.Adi} {o.SoyAdi}"); //Console.WriteLine("Adı :" + o.Adi);
                Console.WriteLine($"Tc :{o.Tc}");
                Console.WriteLine("".PadRight(30, '-'));
                ;
            });

            Console.WriteLine("Listeleme Tamamlandı".PadRight(30, '-'));

        }


    }
}
