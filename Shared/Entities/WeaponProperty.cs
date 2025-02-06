namespace MasterAdvantage.Shared.Entities
{
    public class WeaponProperty
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Effects { get; set; } = "";
        public List<Weapon> Weapons { get; set; } = [];
    }
}
