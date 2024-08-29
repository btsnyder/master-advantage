namespace MasterAdvantage.Shared.Components
{
    public class Encounter
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public ICollection<EncounterItem> Items { get; set; } = new List<EncounterItem>();
    }
}
