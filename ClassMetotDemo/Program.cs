using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adı + musteri.Soyad);

        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Adı + musteri.Soyad);

        }

        public void Listeleme(Musteri[] musteri)
        {
            foreach (var listele in musteri)

            {
                Console.WriteLine(listele.ID + listele.Adı + listele.Soyad + listele.Yas + listele.HesapBılgısı + listele.Parası);
            }

        }

    }


} 

