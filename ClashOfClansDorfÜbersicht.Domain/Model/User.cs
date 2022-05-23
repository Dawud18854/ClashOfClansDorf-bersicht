using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class User : EntityBase
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual List<GameAccount> GameAccounts { get; set; } = default!;
    }
}
