using MasterAdvantage.Shared.Entities;

namespace MasterAdvantage.Shared.Components
{
    public class EncounterItem
    {
        public Guid Id { get; set; }
        public int Initiative { get; set; }
        public Guid? CreatureId { get; set; }
        public Creature Creature { get; set; }
        public Character? Character => IsNPC ? null : (Character)Creature;
        public int CurrentHP { get; set; }
        public int TempHP { get; set; }
        public int CurrentMana { get; set; }
        public int CurrentStamina { get; set; }
        public int CurrentRestPoints { get; set; }
        public int CurrentGritPoints { get; set; }
        public int ActionsUsed { get; set; }
        public bool Hidden { get; set; }
        public bool ConditionsOpen { get; set; }
        public List<string> Conditions { get; set; } = new();
        public bool IsNPC => Creature.GetType() != typeof(Character);
        public string RowClass => Hidden ? "mud-theme-dark" : "";
        public Guid EncounterId { get; set; }
        public Encounter Encounter { get; set; }
    }
}
