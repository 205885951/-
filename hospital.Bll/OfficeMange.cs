using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class OfficeMange : IBll.IOfficeMange
    {
        private readonly IDAl.IOfficeServer Office;

        public OfficeMange(IDAl.IOfficeServer server)
        {
            Office = server;
        }
        public async Task Add(string name)
        {
            await Office.Add(new Models.Office() {Name = name});
        }

        public async Task<List<Office>> All()
        {
           return await Task.Run(() =>
            {
                return Office.All().Select(m => new DTo.Office() {Id = m.Id, Name = m.Name}).ToList(); });
        }

        public async Task Rome(int Id)
        {
            await Office.Rome(new Models.Office() {Id = Id});
        }

        public async Task Update(int Id, string name)
        {
            await Office.Update(new Models.Office() {Id = Id, Name = name});
        }
    }
}
