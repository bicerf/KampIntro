using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi:  " + product.Adi);

        }
        public void Ekle2(Product product)
        {
            Console.WriteLine("Sepete eklediniz efenim! " + product.Adi +' ' + product.Aciklama + " "+product.StokAdedi);
        }
    }

    
}
