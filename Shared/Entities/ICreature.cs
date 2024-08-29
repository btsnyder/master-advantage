namespace Shared.Entities
{
    public interface ICreature
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Stamina { get; set; }
        public int MaxStamina { get; set; }
        public int ActionPoints { get; set; }
        public int PD { get; set; }
        public int MD { get; set; }
        public int PDR { get; set; }
        public int MDR { get; set; }
    }
}
