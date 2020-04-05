using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using StudyFlashCards.Models;

namespace StudyFlashCards.Data
{
    public class DecksDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public DecksDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Deck>().Wait();
        }

        public Task<List<Deck>> GetDecksAsync()
        {
            return _database.Table<Deck>().ToListAsync();
        }

        public Task<Deck> GetDeckAsync(int id)
        {
            return _database.Table<Deck>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveDeckAsync(Deck deck)
        {
            if (deck.ID != 0)
            {
                return _database.UpdateAsync(deck);
            }
            else
            {
                return _database.InsertAsync(deck);
            }
        }

        public Task<int> DeleteDeckAsync(Deck note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
