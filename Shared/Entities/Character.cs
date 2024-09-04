namespace MasterAdvantage.Shared.Entities
{
    public class Character : Creature
    {
        public string? PlayerName { get; set; }
        public int Level { get; set; } = 1;
        public int CombatMastery => (int)Math.Round((decimal)Level / 2, 0, MidpointRounding.AwayFromZero);
        public bool MightSave { get; set; }
        public bool AgilitySave { get; set; }
        public bool CharismaSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public int AwarenessMastery { get; set; }
        public int Awareness => Prime + AwarenessMastery * 2;
        public int AthleticsMastery { get; set; }
        public int Athletics => Might + AthleticsMastery * 2;
        public int IntimidationMastery { get; set; }
        public int Intimidation => Might + IntimidationMastery * 2;
        public int AcrobaticsMastery { get; set; }
        public int Acrobatics => Agility + AcrobaticsMastery * 2;
        public int TrickeryMastery { get; set; }
        public int Trickery => Agility + TrickeryMastery * 2;
        public int StealthMastery { get; set; }
        public int Stealth => Agility + StealthMastery * 2;
        public int AnimalMastery { get; set; }
        public int Animal => Charisma + AnimalMastery * 2;
        public int InfluenceMastery { get; set; }
        public int Influence => Charisma + InfluenceMastery * 2;
        public int InsightMastery { get; set; }
        public int Insight => Charisma + InsightMastery * 2;
        public int InvestigationMastery { get; set; }
        public int Investigation => Intelligence + InvestigationMastery * 2;
        public int MedicineMastery { get; set; }
        public int Medicine => Intelligence + MedicineMastery * 2;
        public int SurvivalMastery { get; set; }
        public int Survival => Intelligence + SurvivalMastery * 2;
        public int ArcanaMastery { get; set; }
        public int Arcana => Intelligence + ArcanaMastery * 2;
        public int HistoryMastery { get; set; }
        public int History => Intelligence + HistoryMastery * 2;
        public int NatureMastery { get; set; }
        public int Nature => Intelligence + NatureMastery * 2;
        public int OccultismMastery { get; set; }
        public int Occultism => Intelligence + OccultismMastery * 2;
        public int ReligionMastery { get; set; }
        public int Religion => Intelligence + ReligionMastery * 2;
        public string CustomKnowledge1Name { get; set; } = "";
        public int CustomKnowledge1Mastery { get; set; }
        public int CustomKnowledge1 => Intelligence + CustomKnowledge1Mastery * 2;
        public string CustomKnowledge2Name { get; set; } = "";
        public int CustomKnowledge2Mastery { get; set; }
        public int CustomKnowledge2 => Intelligence + CustomKnowledge2Mastery * 2;
        public List<Trade> Trades { get; set; }

        public int SkillMasteryLimit => (Level / 5) + 1;

        public Dictionary<string, string[]> AttributeSkills = new()
        {
            { nameof(Prime), new string[] { nameof(Awareness) } },
            { nameof(Might), new string[] { nameof(Athletics), nameof(Intimidation) } },
            { nameof(Agility), new string[] { nameof(Acrobatics), nameof(Trickery), nameof(Stealth) } },
            { nameof(Charisma), new string[] { nameof(Animal), nameof(Influence), nameof(Insight) } },
            { nameof(Intelligence), new string[] { nameof(Investigation), nameof(Medicine), nameof(Survival), nameof(Arcana), 
                nameof(History), nameof(Nature), nameof(Occultism), nameof(Religion), nameof(CustomKnowledge1), nameof(CustomKnowledge2)} }

        };
    }
}
 