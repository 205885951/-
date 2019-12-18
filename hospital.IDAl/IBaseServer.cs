using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hospital.IDAl
{
    public interface IBaseServer<T> where T:Models.BaseModels
    {
        Task Add(T t);
        Task Rome(T t);
        Task Update(T t);
        List<T> All();
    }
}
