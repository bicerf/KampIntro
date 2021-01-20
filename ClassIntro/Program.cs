using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Furkan BİÇER";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Ali";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Esra";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "İrem";
            kurs4.IzlenmeOrani =75;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1 ,kurs2 ,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni);
            }          
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
