using MasterAdvantage.Shared.Components;
using MasterAdvantage.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MasterAdvantage.Data
{
    public class DBService
    {
        #region Private members
        private MasterAdvantageContext dbContext;
        #endregion

        #region Constructor
        public DBService(MasterAdvantageContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        public async Task<Encounter> GetEncounter(Guid id)
        {
            var encounter = dbContext.Encounters
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => ((Character)c).Trades)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Weapons).ThenInclude(w => w.WeaponProperties)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Weapons).ThenInclude(w => w.Style)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Spells).ThenInclude(s => s.Enhancements)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Maneuvers).ThenInclude(t => t.Enhancements)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Items)
                .First(e => e.Id == id);
            foreach (var i in encounter.Items)
            {
                await dbContext.Entry(i).ReloadAsync();
                await dbContext.Entry(i.Creature).ReloadAsync();
            }
            await dbContext.Entry(encounter).ReloadAsync();
            return encounter;
        }
        public List<Encounter> GetEncounters()
        {
            return dbContext.Encounters
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => ((Character)c).Trades)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Weapons).ThenInclude(w => w.WeaponProperties)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Weapons).ThenInclude(w => w.Style)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Spells).ThenInclude(s => s.Enhancements)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Maneuvers).ThenInclude(t => t.Enhancements)
                .Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => c.Items)
                .ToList();
        }

        public async Task<T> UpdateAsync<T>(T entity) where T : class
        {
            EntityEntry<T> saved = dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
            return saved.Entity;
        }

        public async Task<Encounter> UpdateEncounterAsync(Encounter encounter)
        {
            try
            {
                foreach (var item in encounter.Items)
                {
                    await UpdateCreature(item.Creature);
                    if (dbContext.EncounterItems.Contains(item))
                    {
                        dbContext.Update(item);
                    }
                    else
                    {
                        dbContext.Add(item); 
                    }
                }
                if (dbContext.Encounters.Contains(encounter))
                {
                    dbContext.Update(encounter);
                }
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return encounter;
        }

        public Guid GetEncounterChangeId(Guid encounterId)
        {
            return dbContext.Encounters.Where(e => e.Id == encounterId).Select(e => e.ChangeId).Single();
        }

        public async Task<Creature> UpdateCreature(Creature creature)
        {
            try
            {
                dbContext.Update(creature);
                if (creature.GetType() == typeof(Character))
                {
                    Character character = (Character) creature;
                    foreach (var trade in character.Trades)
                    {
                        dbContext.Update(trade);
                    }
                }
                foreach (var weapon in creature.Weapons)
                {
                    dbContext.Update(weapon);
                }
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return creature;
        }

        public async Task<EncounterItem> UpdateEncounterItem(EncounterItem item)
        {
            try
            {
                dbContext.Update(item);
                await UpdateCreature(item.Creature);
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        public async Task DeleteEncounterAsync(Encounter encounter)
        {
            try
            {
                dbContext.Encounters.Remove(encounter);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Creature>> SearchCreature(string name)
        {
            return await dbContext.Creatures.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<Creature?> GetCreatureByName(string name)
        {
            var character = dbContext.Characters.Where(c => c.Name == name).FirstOrDefault();
            if (character == null)
                return await dbContext.Creatures.Where(c => c.Name == name).FirstOrDefaultAsync();
            return character;
        }


        public async Task<List<Weapon>> GetWeaponsAsync()
        {
            return await dbContext.Weapons.OrderBy(w => w.Name).ToListAsync();
        }

        public async Task<List<Weapon>> SearchWeaponsAsync(string name)
        {
            return await dbContext.Weapons.Where(w => w.Name.ToLower().Contains(name.ToLower())).OrderBy(w => w.Name).ToListAsync();
        }

        public async Task<List<WeaponStyle>> GetWeaponStylesAsync()
        {
            return await dbContext.WeaponStyles.ToListAsync();
        }

        public async Task<List<WeaponProperty>> GetWeaponPropertiesAsync()
        {
            return await dbContext.WeaponProperties.ToListAsync();
        }

        public async Task<List<Spell>> GetSpellsAsync()
        {
            return await dbContext.Spells.OrderBy(s => s.Name).Include(s => s.Enhancements).ToListAsync();
        }

        public async Task<List<Spell>> SearchSpellsAsync(string name)
        {
            return await dbContext.Spells.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task DeleteSpellEnhancementAsync(SpellEnhancement enhancement)
        {
            try
            {
                dbContext.SpellEnhancements.Remove(enhancement);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteSpell(Spell spell)
        {
            try
            { 
                dbContext.Spells.Remove(spell);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<CombatAction>> GetActions()
        {
            return await dbContext.Actions.OrderBy(a => a.Name).ToListAsync();
        }

        public async Task<List<Maneuver>> GetManeuversAsync()
        {
            return await dbContext.Maneuvers.OrderBy(m => m.Category).ThenBy(s => s.Name).Include(s => s.Enhancements).ToListAsync();
        }

        public async Task<List<Maneuver>> SearchManeuversAsync(string name)
        {
            return await dbContext.Maneuvers.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task DeleteManeuverEnhancementAsync(ManeuverEnhancement enhancement)
        {
            try
            {
                dbContext.ManeuverEnhancements.Remove(enhancement);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteManeuver(Maneuver maneuver)
        {
            try
            { 
                dbContext.Maneuvers.Remove(maneuver);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
