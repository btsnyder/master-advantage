using MasterAdvantage.Shared.Components.Enums;

namespace MasterAdvantage.Shared.Entities
{
    public class Maneuver
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AP { get; set; }
        public int SP { get; set; }
        public ManeuverCategory Category { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<ManeuverEnhancement> Enhancements { get; set; } = new();
        public string GetCost()
        {
            string cost = string.Empty;
            if (AP > 0)
            {
                cost = string.Format("{0} AP", AP);
                if (SP > 0)
                {
                    cost += " + ";
                }
            }
            if (SP > 0)
            {
                cost += string.Format("{0} SP", SP);
            }
            return cost;
        }
    }
}
