using ATM_Console;

class Program
{
    static void Main(string[] args)
    {
        MusteriHakkında[] musteriler = new MusteriHakkında[10];//tüm sistem 10 kişi ile sınırlı
        int i = 0;
        while (true)
        {
            Console.WriteLine("##ATM ye HOŞGELDİNİZ##\nYapmak istediğiniz işlemi tuşlayınız: ");
            Console.WriteLine("1-Üye Ol");
            Console.WriteLine("2-Giriş Yap");
            Console.WriteLine("3-Çık");
            int birincisecim = Convert.ToInt32(Console.ReadLine());
            if (birincisecim == 1)
            {
                if (i >= musteriler.Length)
                {
                    Console.WriteLine("Maksimum müşteri sayısına ulaşıldı!");
                    continue;
                }
                musteriler[i] = new MusteriHakkında();
                Console.Write("Lütfen isminizi yazın: ");
                musteriler[i].MusteriIsmi = Console.ReadLine();
                musteriler[i].MusteriNoOlustur();
                Console.Write("Lütfen parolanızı yazın: ");
                musteriler[i].MusteriParola = Console.ReadLine();
                musteriler[i].yeniuyebilgi();
                i++;

            }
            else if (birincisecim == 2)
            {
                int j;
                bool sifredeneme = true;
                while (true)
                {
                    bool numarabulma = false;
                    Console.Write("Müşteri numaranızı giriniz: ");
                    int girilennumara = Convert.ToInt32(Console.ReadLine());
                    for (j = 0; j < 10; j++)
                    {
                        if (musteriler[j] != null && musteriler[j].musteriNo == girilennumara)
                        {
                            numarabulma = true;
                            break;
                        }
                    }
                    if (numarabulma)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir kullanıcı yok tekrar dene");
                    }

                }
                while (sifredeneme)
                {
                    Console.Write("Lütfen parolanızı giriniz: ");
                    string girilenparola = Console.ReadLine();
                    if (musteriler[j].MusteriParola == girilenparola)
                    {
                        sifredeneme = false;
                    }
                    else
                    {
                        Console.WriteLine("Parola yanlış!!!");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Şuanki bakiyeniz: " + musteriler[j].bakiye);
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1-Para ekle");
                    Console.WriteLine("2-Para çek");
                    Console.WriteLine("3-Çıkış");
                    int ikincisecim = Convert.ToInt32(Console.ReadLine());
                    if (ikincisecim == 1)
                    {
                        Console.WriteLine("Eklemek istediğiniz tutarı giriniz:");
                        int eklenecek = Convert.ToInt32(Console.ReadLine());
                        musteriler[j].ParaEkle(eklenecek);
                    }
                    else if (ikincisecim == 2)
                    {
                        Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                        int cekilecek = Convert.ToInt32(Console.ReadLine());
                        musteriler[j].ParaCek(cekilecek);
                    }
                    else if (ikincisecim == 3)
                    {
                        Console.WriteLine("Çıkış yapıldı");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Hatalı tuşlama tekrar dene");
                    }
                }

            }
            else if (birincisecim == 3)
            {
                Console.WriteLine("Çıkış yapıldı");
                break;
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama tekrar dene");
            }
        }
    }
}