using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices)  //istersen taşıt ister konnut hangi kredi türü istersen gönder hesaplanır çünkü hepsi implemente edildi
        {
            //Başvuran bilgilerini değerlendiririz kod olur burada bir sürü
            //
            creditManager.Calculate();
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditOnBilgilendirmesiYap(List<ICreditManager> credits) //Liste yaparak hangi kredi türü seçilirse onu hesaplamalık bir yapı oluşturduk
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
