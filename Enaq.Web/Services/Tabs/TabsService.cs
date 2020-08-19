using System;
using Enaq.Web.Data;

namespace Enaq.Web.Services.Tabs
{
    public interface ITabsService
    {
        void AddTab();
    }

    public class TabsService : ITabsService
    {
        private readonly ITabRepository _tabRepository;

        public TabsService(ITabRepository tabRepository)
        {
            _tabRepository = tabRepository;
        }

        public void AddTab()
        {
            _tabRepository.Add(new Tab
            {
                Url = new Uri("https://httpbin.org/anything")
            });
        }
    }
}