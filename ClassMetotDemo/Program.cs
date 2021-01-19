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

            

        }
    }
}
