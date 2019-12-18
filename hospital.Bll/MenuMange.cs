using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class MenuMange : IBll.IMenuMange
    {
        private readonly IDAl.IMenuServer menu;

        public MenuMange(IDAl.IMenuServer server)
        {
            menu = server;
        }
        public async Task Add(string type, string url, int PrparentId)
        {
            await menu.Add(new Models.Menu() {Type = type, Url = url, PrparentId = PrparentId});
        }

        public Task<List<Menu>> All()
        {
            throw new NotImplementedException();
        }

        public async Task Rome(int Id)
        {
            await menu.Rome(new Models.Menu() {Id = Id});
        }

        public async Task Update(int Id, string type, string url, int PrparentId)
        {
            await menu.Update(new Models.Menu() {Id = Id, Type = type, Url = url, PrparentId = PrparentId});
        }
    }
}
