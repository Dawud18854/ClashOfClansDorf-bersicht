namespace ClashOfClansDorfÜbersicht.Domain.Model
{
    public class GameAccount : EntityBase
    {
        public string IngameName { get; set; }
        public DateTime CreationDate { get; set; } 
        public string Email { get; set; } 
        public int VillageId { get; set; }
        public Village Village { get; set; } = default!;
        public int UserId { get; set; }
        public User User { get; set; } = default!;
    }
}