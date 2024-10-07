namespace MasterAdvantage.Shared.Entities
{
    public class SpellEnhancement
    {
        public Guid Id { get; set; }
        public Guid SpellId { get; set; }
        public Spell Spell { get; set; }
        public string Name { get; set; } = "";
        public int AP { get; set; }
        public int MP { get; set; }
        public string Description { get; set; } = "";
    }
}
