using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class Village : EntityBase
    {
        public long Gold { get; set; }
        public long Elexir { get; set; }
        public long DarkElexir { get; set; }
        public int Gems { get; set; } 
        public int Worker { get; set; }
        public int Trophies { get; set; }
        public string Rank { get; set; } = string.Empty;
        public string GuildRank { get; set; } = "New";
        public int ClanId { get; set; }
        public virtual Clan Clan { get; set; } = default!;
        public string VillageName { get; set; } = string.Empty;
        public virtual List<Building> Buildings { get; set; } = default!;
    }
}
