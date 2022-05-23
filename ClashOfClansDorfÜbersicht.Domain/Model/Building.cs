using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class Building : EntityBase
    {
        public string Name { get; set; }
        public int CurrentLevel { get; set; }
        public string Description { get; set; }
        public int MaxLevel { get; set; }
        public int VillageId { get; set; }
        public Village Village { get; set; } = default!;
    }
}
