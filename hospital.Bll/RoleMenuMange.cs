using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class RoleMenuMange : IBll.IRoleMenuMange
    {
        private readonly IDAl.IRoleMenuServer RoleMenu;

        public RoleMenuMange(IDAl.IRoleMenuServer role)
        {
            RoleMenu = role;
        }
        public async Task Add(int RoleId, int MenID)
        {
            await RoleMenu.Add(new Models.RoleMenu());
        }

        public Task<List<RoleMenu>> All()
        {
            throw new NotImplementedException();
        }

        public  async Task Rome(int Id)
        {
            await RoleMenu.Rome(new Models.RoleMenu() {Id = Id});
        }

        public async Task Update(int Id, int RoleId, int MenID)
        {
            await RoleMenu.Update(new Models.RoleMenu() {Id = Id, RoleId = RoleId, MenuId = MenID});
        }
    }
}
