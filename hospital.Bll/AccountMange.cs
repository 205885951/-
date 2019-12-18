using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using hospital.DTo;
using hospital.Models.Exprs;

namespace hospital.Bll
{
    public class AccountMange : IBll.IAccountMange
    {
        private readonly IDAl.IAccountServer account;

        public AccountMange(IDAl.IAccountServer server)
        {
            account = server;
        }
        public async Task Add(int PatientBlockId, long Balance)
        {
            await account.Add(new Models.Exprs.Account() {PatientBlockId = PatientBlockId, Balance = Balance});
        }

        public  Task<List<DTo.Account>> All()
        {


            throw new NotImplementedException();
        }

    public async Task Rome(int Id)
        {
            await account.Rome(new Models.Exprs.Account() {Id = Id});

        }

        public async Task Update(int Id, int PatientBlockId, long Balance)
        {
            await account.Update(new Models.Exprs.Account() {Id = Id, PatientBlockId = PatientBlockId, Balance = Balance});
        }
    }
}
