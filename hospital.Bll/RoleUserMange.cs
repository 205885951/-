using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.Models;
using SqlSugar;
using RoleUser = hospital.DTo.RoleUser;

namespace hospital.Bll
{
    public class RoleUserMange : IBll.IRoleUserMange
    {
        private readonly IDAl.IRoleUserServer RoleUser;

        public RoleUserMange(IDAl.IRoleUserServer role)
        {
            RoleUser = role;
        }
        public async Task Add(string name, int roleId, int AdminUserId)
        {
            await RoleUser.Add(new Models.RoleUser() {Name = name, RoleId = roleId, AdministratorId = AdminUserId});
        }

        public async Task<List<RoleUser>> All()
        {
            using (DbContext db=new DbContext())
            {
                return await db.Db.Queryable<RoleUser, Role, AdministratorUser>((st, sc, ed) => new object[]
                {
                    JoinType.Left, st.RoleId == sc.Id,
                    JoinType.Left, st.AdminUserId == ed.Id
                }).Select((st, sc, ed) => new DTo.RoleUser()
                {
                    Id = st.Id, Name = st.Name, RoleId = st.RoleId, AdminUserId = st.AdminUserId, Account = ed.Account,
                    RoleName = sc.Name
                }).ToListAsync();
            }


        }

        public async Task Rome(int ID)
        {
            await RoleUser.Rome(new Models.RoleUser() {Id = ID});
        }

        public async Task Update(int Id, string Name, int roleId, int AdminUserId)
        {
            await RoleUser.Update(new Models.RoleUser()
                {Id = Id, Name = Name, RoleId = roleId, AdministratorId = AdminUserId});
        }
    }
}
