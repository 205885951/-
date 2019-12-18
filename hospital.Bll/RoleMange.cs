using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.Models;
using Role = hospital.DTo.Role;

namespace hospital.Bll
{
    public class RoleMange : IBll.IRoleMange
    {
        private readonly IDAl.IRoleServer Role;

        public RoleMange(IDAl.IRoleServer server)
        {
            Role = server;
        }
        public async Task Add(string Name)
        {
           await Role.Add(new Models.Role() {Name = Name});
        }

        public async Task<List<Role>> All()
        {
            return await Task.Run(() =>
            {
                return Role.All().Select(m => new DTo.Role() {Id = m.Id, Name = m.Name, DateTimeS = m.DateTimes})
                    .ToList();
            });
        }

        public async Task Rome(int Id)
        {
            await Role.Rome(new Models.Role() {Id = Id});
        }

        public async Task Update(int Id, string name)
        {
            await Role.Update(new Models.Role() {Id = Id, Name = name});
        }
    }
}
