using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATM_Console
{
    internal class MusteriHakkında
    {
        public int musteriNo;
        private string musteriIsmi;
        private string musteriParola;

        public int bakiye;

        public string MusteriIsmi
        {
            get { return musteriIsmi; }
            set{ musteriIsmi = value; }
        }

        public void MusteriNoOlustur()
        {
            Random rnd = new Random();
            musteriNo = rnd.Next(0, 101);
        }

        public string MusteriParola
        {
            get { return musteriParola; }
            set { musteriParola = value; }
        }

        public void yeniuyebilgi()
        {
            Console.WriteLine($"Sayın {musteriIsmi} adlı kullanıcımız müşteri numaranız: {musteriNo}");
        }

        public void ParaEkle(int tutar)
        {
            bool islem = false;

            if (tutar > 0)
            {
                bakiye += tutar;
                islem = true;
            }
            else
            {
                Console.WriteLine("Girdiğiniz tutar geçersizdir tekrar deneyiniz");
            }
            
        }

        public void ParaCek(int tutar)
        {
            bool islem = false;

            if (tutar > 0 && tutar <= bakiye)
            {
                bakiye -= tutar;
                islem = true;
            }
            else if (tutar > 0 && bakiye > 0)
            {
                Console.WriteLine("Girdiğiniz tutar bakiye üzerinde lütfen tekrar deneyiniz");
            }
            else
            {
                Console.WriteLine("Girdiğiniz tutar geçersizdir tekrar deneyiniz");
            }
        }

    }
}
