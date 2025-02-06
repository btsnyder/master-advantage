namespace MasterAdvantage.Shared.Entities
{
    public class Trade
    {
        public Guid Id { get; set; }
        public int Mastery { get; set; }
        public string Name { get; set; } = "";
        public string? Attribute { get; set; }
        public Guid CharacterId { get; set; }
        public Character Character { get; set; } = new();


        public int GetValue()
        {
            int att = Attribute == null ? 0 : Helpers.GetPropertyByName<int>(Character, Attribute);
            return att + Mastery * 2;
        }
    }
}
