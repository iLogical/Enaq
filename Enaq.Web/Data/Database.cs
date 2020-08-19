using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Blazor.IndexedDB.WebAssembly;

namespace Enaq.Web.Data
{
    public interface IDatabase
    {
        Task<T> OpenSession<T>() where T : IndexedDb;
    }

    public class Database : IDatabase
    {
        private readonly IIndexedDbFactory _dbFactory;
        
        public Database(IIndexedDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        
        public async Task<T> OpenSession<T>() where T : IndexedDb
        {
            Console.WriteLine("Before");
            return await _dbFactory.Create<T>();
        }
    }

    public class Record 
    {
        [Key]
        public long Id { get; set; }
    }
}