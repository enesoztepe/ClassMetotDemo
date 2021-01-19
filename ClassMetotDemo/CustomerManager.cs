using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer custom)
        {
            Console.WriteLine(custom.Name + " " + custom.Surname + " adlı müşteri eklenmiştir.");
        }
        public void Delete(Customer custom)
        {
            Console.WriteLine(custom.Name + " " + custom.Surname + " adlı müşteri silinmiştir.");
        }
        public void List(Customer[] custom)
        {
            Console.WriteLine("Müşteriler,\n");
            foreach (var cus in custom)
            {
                Console.WriteLine("(" + cus.Id + ") " + cus.Name + " " + cus.Surname);
            }
        }
    }
}
