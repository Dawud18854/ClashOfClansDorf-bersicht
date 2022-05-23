using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class Clan : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Member { get; set; }
        public virtual List<Village> Villages { get; set; } = default!;
    }
}
