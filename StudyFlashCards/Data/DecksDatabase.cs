using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using StudyFlashCards.Models;

namespace StudyFlashCards.Data
{
    public class DecksDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public DecksDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Deck).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Deck)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        public Task<List<Deck>> GetItemsAsync()
        {
            return Database.Table<Deck>().ToListAsync();
        }

        public Task<List<Deck>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<Deck>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Deck> GetItemAsync(int id)
        {
            return Database.Table<Deck>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Deck item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Deck item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
