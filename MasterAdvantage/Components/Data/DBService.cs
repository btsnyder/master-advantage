using MasterAdvantage.Shared.Components;
using MasterAdvantage.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Entities;
using System.Diagnostics.Metrics;
using static MudBlazor.CategoryTypes;
using static MudBlazor.Colors;

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
            var encounter = dbContext.Encounters.Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => ((Character)c).Trades).First(e => e.Id == id);
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
            return dbContext.Encounters.Include(e => e.Items).ThenInclude(i => i.Creature).ThenInclude(c => ((Character)c).Trades).ToList();
        }

        public async Task<Encounter> AddEncounterAsync(Encounter encounter)
        {
            try
            {
                dbContext.Encounters?.Add(encounter);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return encounter;
        }

        public async Task<EncounterItem> AddEncounterItem(EncounterItem item)
        {
            try
            {
                dbContext.EncounterItems?.Add(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        public async Task<Creature> AddCreature(Creature creature)
        {
            try
            {
                dbContext.Creatures?.Add(creature);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return creature;

        }

        public async Task<Encounter> UpdateEncounterAsync(Encounter encounter)
        {
            try
            {
                foreach (var item in encounter.Items)
                {
                    if (item.IsNPC)
                    {
                        if (dbContext.Creatures.Contains(item.Creature))
                        {
                            dbContext.Update(item.Creature);
                        }
                        else
                        {
                            dbContext.Add(item.Creature);
                        }
                    }
                    else
                    {
                        dbContext.Update(item.Creature);
                    }
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
            return await dbContext.Weapons.ToListAsync();
        }

        public async Task<List<Weapon>> SearchWeaponsAsync(string name)
        {
            return await dbContext.Weapons.Where(w => w.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<WeaponStyle> UpdateWeaponStyleAsync(WeaponStyle style)
        {
            try
            {
                dbContext.WeaponStyles.Update(style);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return style;
        }

        public async Task<WeaponProperty> UpdateWeaponPropertyAsync(WeaponProperty prop)
        {
            try
            {
                dbContext.WeaponProperties.Update(prop);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return prop;
        }

        public async Task<List<WeaponStyle>> GetWeaponStylesAsync()
        {
            return await dbContext.WeaponStyles.ToListAsync();
        }

        public async Task<List<WeaponProperty>> GetWeaponPropertiesAsync()
        {
            return await dbContext.WeaponProperties.ToListAsync();
        }

        public async Task<Weapon> UpdateWeapon(Weapon weapon)
        {
            try
            {
                dbContext.Weapons.Update(weapon);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return weapon;
        }
        #endregion
    }
}
