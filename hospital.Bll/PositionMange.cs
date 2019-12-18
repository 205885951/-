using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;

namespace hospital.Bll
{
    public class PositionMange : IBll.IPositionMange
    {
        private readonly IDAl.IPositionServer PostServer;

        public PositionMange(IDAl.IPositionServer server)
        {
            PostServer = server;
        }
        public async Task Add(string name)
        {
            await PostServer.Add(new Models.Position() {Name = name});
        }

        public async Task<List<Position>> All()
        {
           return await Task.Run(() =>
           {
               return PostServer.All().Select(m => new DTo.Position() {Id = m.Id, Name = m.Name}).ToList();
           });
        }

        public async Task Rome(int Id)
        {
            await PostServer.Rome(new Models.Position() {Id = Id});
        }

        public async Task Update(int Id, string name)
        {
            await PostServer.Update(new Models.Position() {Id = Id, Name = name});
        }
    }
}
