using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriBigileri

    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.ID = 4456465;
            musteri.Adı = "Hasan";
            musteri.Soyad = "Büyük";
            musteri.Yas = 35;
            musteri.HesapBılgısı = "vadeli";
            musteri.Parası = 10000;

            Musteri musteri2 = new Musteri();
            musteri.ID = 485964;
            musteri.Adı = "Ali";
            musteri.Soyad = "Genç";
            musteri.Yas = 40;
            musteri.HesapBılgısı = "vadeli";
            musteri.Parası = 80000;

            Musteri musteri3 = new Musteri();
            musteri.ID = 1235468;
            musteri.Adı = "Emine";
            musteri.Soyad = "Yıldız";
            musteri.Yas = 26;
            musteri.HesapBılgısı = "vadesiz";
            musteri.Parası = 50000;

        }
        
    }
}
