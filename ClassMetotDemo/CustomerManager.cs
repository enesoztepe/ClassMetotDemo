using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public static void Add(Customer custom)
        {
            Console.WriteLine(custom.Name + " " + custom.Surname + " adlı müşteri eklenmiştir.");
        }
        public static void Delete(Customer custom)
        {
            Console.WriteLine(custom.Name + " " + custom.Surname + " adlı müşteri silinmiştir.");
        }
        public static void List(Customer[] custom)
        {
            Console.WriteLine("Müşteriler,\n");
            foreach (var cus in custom)
            {
                Console.WriteLine("(" + cus.Id + ") " + cus.Name + " " + cus.Surname);
            }
        }
    }
}
