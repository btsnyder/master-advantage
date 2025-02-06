namespace MasterAdvantage.Shared.Entities
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public Guid CreatureId { get; set; }
        public Creature Creature { get; set; } = new();
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Quantity { get; set; }
    }
}
