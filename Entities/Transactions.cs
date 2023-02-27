using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalADO.Entities
{
    public class Transactions
    {
        public Guid Id { get; set; }
        // по идее не должно быть,но пока оставлю 2 айди крипты и инвесторов
        public Guid CryptocurrencyId { get; set; }
        public Guid? InvestorId { get; set; }

        public DateTime TransactionDate { get; set; }
        // тот же самый null
        public string TransactionType { get; set; }

        public double TransactionAmount { get; set; }

        public String ToShortString()
        {
            return Id.ToString()[..4] + "... " + TransactionType;
        }

    }
}
