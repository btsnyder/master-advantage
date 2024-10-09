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
        public string Senses { get; set; } = "";
        public string Languages { get; set; } = "";
        public string Features { get; set; } = "";
        public string Actions { get; set; } = "";
        public string Enhancements { get; set; } = "";
        public string Reactions { get; set; } = "";
        public int Attack { get; set; }
        public int SaveDC { get; set; }

        public List<Weapon> Weapons { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
    }
}
