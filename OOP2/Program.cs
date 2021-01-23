using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer ındividualCustomer1 = new IndividualCustomer();
            ındividualCustomer1.CustomerNumber = "12355";
            ındividualCustomer1.FirstName = "Furkan";
            ındividualCustomer1.LastName = "Biçer";
            ındividualCustomer1.TcNo = "1234567890";

            CorporateClient corporateClien1 = new CorporateClient();
            corporateClien1.Id = 2;
            corporateClien1.CompanyName = "Kodlama.io";
            corporateClien1.TaxNumber = "12345678";
            corporateClien1.CustomerNumber = "1234";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateClient();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add()

        }
    }
}
