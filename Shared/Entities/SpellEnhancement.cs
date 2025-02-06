namespace MasterAdvantage.Shared.Entities
{
    public class SpellEnhancement
    {
        public Guid Id { get; set; }
        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = new();
        public string Name { get; set; } = "";
        public int AP { get; set; }
        public int MP { get; set; }
        public string Description { get; set; } = "";
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
