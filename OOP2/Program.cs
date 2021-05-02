using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bireysel Müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Haktan";
            customer1.CustomerSurname = "Başak";
            customer1.TcNo = "123213124124";
            customer1.Id = 1;

            //Tüzel Müşteri
            CoorparateCustomer customer2 = new CoorparateCustomer();
            customer2.CustomerId = "32132";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "213131";
            customer2.Id = 2;

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorparateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
        }
    }
}
