using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    // Класс Currency описывает данные. Он содержит свойства
    // Id - идентификационный номер элемента, Name - название валюты, 
    // Value - обменный курс.
    // Каждое свойство соответствует столбцу в базе данных

    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
