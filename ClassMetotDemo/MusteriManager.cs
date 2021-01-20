using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public Musteri AddMusteri(Musteri musteri)
        {
            Console.Write("Müşteri Id: ");
            musteri.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Müşteri Adı ve Soyadı: ");
            musteri.Name = Console.ReadLine();
            Console.Write("Para Miktarı: ");
            musteri.Balance = Convert.ToDouble(Console.ReadLine());
            return musteri;
        }
        public Musteri DeleteMusteri(List<Musteri> musteris)
        {

            Console.Write("Silmek istediğiniz müşterinin id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            return musteris.Find(x => x.Id == id);

            
        }
        public void ListMusteri(List<Musteri> musteris)
        {
            foreach (var item in musteris)
            {
                Console.WriteLine("Id: " +item.Id + "\n" + "Ad Soyad: " +item.Name + "\n" + "Para Miktarı: " +item.Balance);
            }
            
        }
        public void ChangeBalance(List<Musteri> musteris)
        {
            Console.Write("Lütfen işlem yapmak istediğiniz id'yi giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Musteri musteri = musteris.Find(x => x.Id == id);

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
            "1. Para Çekme\n" +
            "2. Para Yatırma\n" +
            "3. Çıkış");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Lütfen çekmek istediğiniz tutarı giriniz: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw > musteri.Balance)
                    {
                        Console.WriteLine("Bakiye Yetersiz");
                    }
                    else
                    {
                        musteri.Balance = musteri.Balance - withdraw;
                        Console.WriteLine("Yeni Bakiye: " + musteri.Balance);
                    }
                    break;
                case "2":
                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    musteri.Balance = musteri.Balance + deposit;
                    Console.WriteLine("Yeni Bakiye: " + musteri.Balance);
                    break;
                case "3":
                    Console.WriteLine("Çıkış yaptınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış bir tuşlama yaptınız.");
                    break;
            }
        }
    }
}
