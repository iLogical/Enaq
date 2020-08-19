using System;
using System.Threading.Tasks;

namespace Enaq.Web.Data
{
    public interface ITabRepository
    {
        Task Add(Tab tab);
    }

    public class TabRepository : ITabRepository
    {
        private readonly IDatabase _database;

        public TabRepository(IDatabase database)
        {
            _database = database;
        }

        public async Task Add(Tab tab)
        {
            using var tabDb = await _database.OpenSession<TabDb>();
            Console.WriteLine("After");
            tabDb.Add(tab);
            await tabDb.SaveChanges();
        }
    }
}