using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class Clan : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Member { get; set; }
        public List<Village> Villages { get; set; }
    }
}
