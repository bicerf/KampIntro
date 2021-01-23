using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //TÜZEL MÜŞTERİ
    class CorporateClient :Customer  //(inheritance (miras))
    {
      
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
