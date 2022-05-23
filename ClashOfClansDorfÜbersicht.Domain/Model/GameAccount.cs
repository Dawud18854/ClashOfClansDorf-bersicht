namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class GameAccount : EntityBase
    {
        public string AccountName { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } 
        public string Email { get; set; } = string.Empty;
        public int VillageId { get; set; }
        public virtual Village Village { get; set; } = default!;
        public int UserId { get; set; }
        public virtual User User { get; set; } = default!;
    }
}