using MasterAdvantage.Shared.Components.Enums;

namespace MasterAdvantage.Shared.Entities
{
    public class Weapon
    {
        public Guid Id { get; set; }
        public Guid WeaponStyleId { get; set; }
        public string Name { get; set; } = "";
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public bool Melee { get; set; }
        public WeaponType Type { get; set; }
        public string Range { get; set; } = "";
        public WeaponStyle Style { get; set; } = new();
        public List<WeaponProperty> WeaponProperties { get; set; } = [];

        public List<Creature> Creatures { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }

        public List<string> GetEffects()
        {
            List<string> effects = WeaponProperties.Select(w => w.Effects).Where(e => e != "").ToList();
            if (!string.IsNullOrEmpty(Name))
            {
                effects.Add(Style.Effect);
            }
            return effects;
        }
    }
}
