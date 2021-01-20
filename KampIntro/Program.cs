using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            double dolardun = 1.45;
            double dolarbugun = 1.30;
            
            if (dolarbugun > dolardun)
            {
                Console.WriteLine("Artış");
            }
            else if (dolardun > dolarbugun)
            {
                Console.WriteLine("azalış");
            }
            else
            {
                Console.WriteLine("eşit");
            }

 

            bool girisYapildiMi = true;

            if (girisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}
