using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();  //interfaceler implemente edildiiği sınıfların referans nolarını tutabilirler o yüzden ICreditManager yazsam da çalışır aynı şey
            
            TasitCreditManager tasitCreditManager = new TasitCreditManager(); //burada tasit yazdım anlasılsın diye ICredit de yazsam aynı şey olacak
            
            ICreditManager konutCreditManager = new KonutCreditManager();

            ICreditManager esnafCreditManager = new EsnafCreditManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(konutCreditManager, new DataBaseLoggerService(),new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() }); //buradaki logu ya da kredi türünü değiştirdiğim takdirde hangi seçeneği istiyorsam sağlarım.İster taşıt ister file logu ya da istediğim farklı kombinasyonlar
            applyManager.Apply(esnafCreditManager, new SmsLoggerService(),new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService() });



            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager, tasitCreditManager}; //Liste yolu ile hesaplama
            //applyManager.CreditOnBilgilendirmesiYap(credits);

        }
    }
}
