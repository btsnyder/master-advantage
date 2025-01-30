using MasterAdvantage.Shared.Components.Enums;
using Microsoft.AspNetCore.Components;

namespace MasterAdvantage.Shared.Entities
{
    public class CombatAction
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty; 
        public ActionCategory Category { get; set; }
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
