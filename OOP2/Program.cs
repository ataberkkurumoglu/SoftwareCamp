using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoorporateCustomer customer1 = new CoorporateCustomer();
            customer1.CustomerNo = "12345";
            customer1.Name = "ataberk";
            customer1.Surname = "kurumoğlu";
            customer1.TcNo = "123124";


            TuzelCustomer customer2 = new TuzelCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "3123";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNo = "213124235";

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new TuzelCustomer();
        }
    }
}
