using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using MasterAdvantage.Shared.Components;
using MasterAdvantage.Shared.Entities;

namespace MasterAdvantage.Data
{
    public class MasterAdvantageContext : DbContext
    {
        public static readonly string MasterAdvantageDb = nameof(MasterAdvantageDb).ToLower();

        public MasterAdvantageContext(DbContextOptions<MasterAdvantageContext> options)
            : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
        }

        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<EncounterItem> EncounterItems { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
