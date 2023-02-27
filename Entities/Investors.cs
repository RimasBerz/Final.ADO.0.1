using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalADO.Entities
{
    public class Investors
    {
        public Guid Id { get; set; }
        //  Имя-фамилия Инвестора(по идее атомарность сохраняется из-за специфики бд), но также равна null
        public string Name { get; set; }

        public String ToShortString()
        {
            return Id.ToString()[..4] + "... " + Name;
        }
    }
}
