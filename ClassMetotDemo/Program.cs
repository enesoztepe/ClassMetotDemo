using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custom1 = new Customer();
            custom1.Id = 1;
            custom1.Name = "Ali";
            custom1.Surname = "VELİ";

            Customer custom2 = new Customer();
            custom2.Id = 2;
            custom2.Name = "Ahmet";
            custom2.Surname = "MEHMET";

            Customer custom3 = new Customer();
            custom3.Id = 3;
            custom3.Name = "Ayşe";
            custom3.Surname = "FATMA";

            Customer[] customers = new Customer[] { custom1, custom2, custom3 };

            CustomerManager.Add(customers[0]);
            CustomerManager.Add(customers[1]);
            CustomerManager.Add(customers[2]);

            CustomerManager.Delete(customers[0]); // CustomerManager da gerçek bir ekleme veya silme işlemi yapmıyoruz sadece görüntülüyoruz.
            CustomerManager.Delete(customers[1]);
            CustomerManager.Delete(customers[2]);

            CustomerManager.List(customers);

            Console.ReadKey();

        }
    }
}
