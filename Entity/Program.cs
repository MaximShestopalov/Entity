using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    // Программа осуществляет создание базы данных Currencies
    // Она хранит данные о курсах валют 

    class Program
    {
        static void Main(string[] args)
        {

            // Добавление в базу данных двух объектов USD, GBP
            using (CurrencyContext db = new CurrencyContext())
            {
                Currency currency1 = new Currency { Name = "USD", Value = 67 };
                Currency currency2 = new Currency { Name = "GBP", Value = 82 };

                db.Currencies.Add(currency1);
                db.Currencies.Add(currency2);
                db.SaveChanges();
                Console.WriteLine("Объекты добавлены в базу данных");


                var currencies = db.Currencies;
                Console.WriteLine("Список объектов:");
                foreach (Currency i in currencies)
                {
                    Console.WriteLine("{0} {1} {2}", i.Id, i.Name, i.Value);
                }
            }
            Console.Read();
        }
    }
}
