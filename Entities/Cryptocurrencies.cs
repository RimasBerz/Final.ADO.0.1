using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalADO.Entities
{
    public class Cryptocurrencies
    {
        public Guid Id { get; set; }
        // null-name ?
        public string Name { get; set; }
        // В БД Count и Price decimal
        public double Count { get; set; }

        public double Price { get; set; }

        public DateTime DateStart { get; set; }
        // Тоже самое
        public double PercentChange { get; set; }

        public String ToShortString()
        {
            return Id.ToString()[..4] + "... " + Name;
        }

       
    }
}
