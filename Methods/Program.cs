using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Id = 1234;
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 12355;

            Product product2 = new Product();
            product2.Adi = "Çilek";
            product2.Id = 4567;
            product2.Fiyat = 30;
            product2.Aciklama = "Silifke Çileği";
            product2.StokAdedi = 4562;

            Product[] products = new Product[] {product1,product2 };  //array yaptım bir nevi küme oluşturduk

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------");

            }


            Console.WriteLine("-----------Metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2(product2);

        }
    }
}
