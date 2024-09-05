namespace MasterAdvantage.Shared.Entities
{
    public class Creature
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public int MaxHP { get; set; }
        public int MaxMana { get; set; }
        public int MaxStamina { get; set; }
        public int ActionPoints { get; set; } = 4;
        public int PD { get; set; }
        public int MD { get; set; }
        public int PDR { get; set; }
        public int MDR { get; set; }
        public string ImageSrc { get; set; } = "";
        private List<int> Attributes => new() { Might, Agility, Charisma, Intelligence };
        public int Prime => Attributes.Max();
        public int Might { get; set; }
        public int Agility { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int Jump { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}
