using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
