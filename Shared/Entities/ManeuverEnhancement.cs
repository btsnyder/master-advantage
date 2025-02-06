namespace MasterAdvantage.Shared.Entities
{
    public class ManeuverEnhancement
    {
        public Guid Id { get; set; }
        public Guid ManeuverId { get; set; }
        public Maneuver Maneuver { get; set; }
        public string Name { get; set; } = "";
        public int AP { get; set; }
        public int SP { get; set; }
        public string Description { get; set; } = "";
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
