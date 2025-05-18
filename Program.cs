using System.Threading.Channels;

namespace ButikSinemaUygulamasi_TP195
{
    internal class Program
    {
        static Sinema snm;
        static void Main(string[] args)
        {
            //Uygulama();

            //tryparsemetodu();

        }

        static void tryparsemetodu()
        {
            while (true)
            {
                Console.Write("sayı girin: ");
                string giriş = Console.ReadLine();

                int sayi;
                bool sonuc = int.TryParse(giriş, out sayi);
                if (sonuc == true)
                {
                    Console.WriteLine(sayi);
                }
                else
                {
                    continue;
                }
            }

        }

        static void Uygulama()
        {
            Kurulum();
            Console.WriteLine();
            Menu();

            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;
                    case "2":
                    case "R":
                        BiletIade();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.WriteLine();

            Console.Write("Film adı:");
            string film = Console.ReadLine();

            Console.Write("Kapasite :");
            int kapasite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tam Bilet Fiyatı :");
            int tam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yarım Bilet Fiyatı :");
            int yarim = Convert.ToInt32(Console.ReadLine());

            //Kurucu metodun bizden istediği bilgileri kullanıcıdan alarak metoda gönderiyoruz.
            snm = new Sinema(film,kapasite,tam,yarim);
        }

        static void Menu()
        {
            Console.WriteLine("1- Bilet Sat (S)");
            Console.WriteLine("2- Bilet İade (R)");
            Console.WriteLine("3- Durum Bilgisi (D)");
            Console.WriteLine("4- Çıkış (X)");
        }

        static void BiletSat()
        {
            Console.Write("Bilet Sat: ");

            Console.Write("Tam Bilet Adedi :");
            int tam = int.Parse(Console.ReadLine());

            Console.Write("Yarım Bilet Adeti :");
            int yarim = int.Parse(Console.ReadLine());

            snm.BiletSatisi(tam, yarim);
            
        }

        static void BiletIade()
        {
            Console.Write("bilet iade: ");

            Console.Write("iade edilecek tam bilet adeti: ");
            int iadetam = int.Parse(Console.ReadLine());

            Console.Write("iade edilecek yarım bilet adeti: ");
            int iadeyarim = int.Parse(Console.ReadLine());

            snm.Biletiadesi(iadetam, iadeyarim);
        }

        static void DurumBilgisi()
        {
            Console.WriteLine("Durum bilgisi: ");
            Console.WriteLine("film: "+ snm.Film );
            Console.WriteLine("katasite: "+snm.Kapasite);
            Console.WriteLine("tam bilet fiyatı: "+snm.TamBiletFiyati);
            Console.WriteLine("yarım bilet fiyatı: "+snm.YarimBiletFiyati);
            Console.WriteLine("toplam tam bilet adeti: "+snm.ToplamTamBiletAdeti);
            Console.WriteLine("toplam yarım bilet adeti: "+snm.ToplamYarimBiletAdeti);
            Console.WriteLine("");
           

            int Ciro = (snm.TamBiletFiyati*snm.ToplamTamBiletAdeti)+(snm.YarimBiletFiyati*snm.ToplamYarimBiletAdeti);
            Console.WriteLine("Ciro: "+Ciro);

            snm.boskoltukadeti();
            Console.WriteLine("bos koltuk adeti: " + snm.BosKoltukAdeti);
        }

        static string SecimAl()
        {
            string karakterler = "1234SRDX";
            int sayac = 0;

            while (true)
            {
                sayac++;
                Console.Write("Seçiminiz : ");
                string giris = Console.ReadLine().ToUpper();

                int index = karakterler.IndexOf(giris);

                if (index >= 0)
                {
                    return giris;
                }
                else
                {
                    if (sayac == 10)
                    {
                        Console.WriteLine("10 hatalı giriş yapıldı.Program sonlandırılıyor.");
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Hatalı İşlem");
                }
                Console.WriteLine();
            }
        }
    }
}
