using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class Building : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public int CurrentLevel { get; set; }
        public string Description { get; set; } = string.Empty;
        public int MaxLevel { get; set; }
        public int VillageId { get; set; }
        public virtual Village Village { get; set; } = default!;
    }
}
