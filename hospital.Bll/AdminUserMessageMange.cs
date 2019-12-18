using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;
using hospital.Models.Exprs;

namespace hospital.Bll
{
    public class AdminUserMessageMange : IBll.IAdminUserMessageMange
    {
        private readonly IDAl.IAdminUserMessageServer admin;

        public AdminUserMessageMange(IDAl.IAdminUserMessageServer server)
        {
            admin = server;
        }
        public async Task Add(string name, int age, string sex, int AdminUserID)
        {
            await admin.Add(new Models.Exprs.AdminUserMessage()
                {Name = name, Age = age, Sex = sex, AdministratorUser = AdminUserID});
        }

        public async Task<List<AdministratorUser>> All()
        {
            throw new NotImplementedException();
        }

        public async Task Rome(int Id)
        {
            await admin.Rome(new Models.Exprs.AdminUserMessage() {Id = Id});
        }

        public async Task Update(int Id, string name, int age, string sex, int AdminUserId)
        {
            await admin.Update(new Models.Exprs.AdminUserMessage()
                {Id = Id, Name = name, Age = age, Sex = sex, AdministratorUser = AdminUserId});
        }
    }
}
