using System.Collections.Generic;
using System.Linq;
using Blazor.IndexedDB.WebAssembly;
using Microsoft.JSInterop;

namespace Enaq.Web.Data
{
    public class TabDb : IndexedDb
    {
        public IndexedSet<Tab> Tabs { get; set; }

        public TabDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version)
        {
        }
        
        public IEnumerable<Tab> GetAll()
        {
            return Tabs.ToList();
        }

        public void Add(Tab tab)
        {
            Tabs.Add(tab);
        }
    }
}