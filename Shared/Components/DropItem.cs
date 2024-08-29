namespace MasterAdvantage.Shared.Components
{
    public class DropItem
    {
        public string Name { get; init; } = "";
        public string Idenifier { get; set; } = "";

        public bool IsPlus() { return Name.StartsWith("+"); }
    }
}
