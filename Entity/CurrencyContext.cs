using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{
    // Контекст данных. Обеспечивает взаимодействие класса Currency, описвающего данные с базой данных
    class CurrencyContext : DbContext
    {
        public CurrencyContext() : base("DbConnection")
        { }

        public DbSet<Currency> Currencies { get; set; }
    }
}
