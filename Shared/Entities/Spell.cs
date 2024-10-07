namespace MasterAdvantage.Shared.Entities
{
    public class Spell
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AP { get; set; }
        public int MP { get; set; }
        public string Range { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public bool Concentration { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<SpellEnhancement> Enhancements { get; set; } = new();
        public string GetCost()
        {
            string cost = string.Empty;
            if (AP > 0)
            {
                cost = string.Format("{0} AP", AP);
                if (MP > 0)
                {
                    cost += " + ";
                }
            }
            if (MP > 0)
            {
                cost += string.Format("{0} MP", MP);
            }
            return cost;
        }
    }
}
