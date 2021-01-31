using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager mng = new MusteriManager();
            mng.Listele();

            // yeni kayıt ekleme
            mng.Ekle(new Musteri
            {
                Adi = "Elif",
                SoyAdi = "Yıldırım",
                Id = 3,
                Tc = "77548965321"
            });

            // aynı tc li kayıt ekleme başarısız olması lazım
            mng.Ekle(new Musteri
            {
                Adi = "Yusuf",
                SoyAdi = "Yıldırım",
                Id = 4,
                Tc = "11296666666"
            });

            mng.Listele();
            ;
            mng.Sil("77548965321");

            mng.Listele();


            // yeni kayıt ekleme
            mng.Guncelle(new Musteri
            {
                Adi = "Ahmet2",
                SoyAdi = "Yıldırım2",
                Tc = "11296666666"
            });



            mng.Listele();
        }
    }
}

