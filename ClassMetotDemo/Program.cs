using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static List<Musteri> musteris = new List<Musteri>();
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                "1. Müşteri Ekleme\n" +
                "2. Müşteri Silme\n" +
                "3. Müşteri Listeleme\n" +
                "4. Hesap Ayarları\n" +
                "5. Çıkış");

            switch (Console.ReadLine())
            {
                case "1":
                    musteris.Add(musteriManager.AddMusteri(new Musteri()));
                    return true;
                case "2":
                    musteris.Remove(musteriManager.DeleteMusteri(musteris));
                    return true;
                case "3":
                    musteriManager.ListMusteri(musteris);
                    return true;
                case "4":
                    musteriManager.ChangeBalance(musteris);
                    return true;
                case "5":
                    return false;
                default:
                    Console.WriteLine("Yanlış bir tuşlama yaptınız. Lütfen tekrar deneyiniz.");
                    return true;
            }
        }
    }
}
