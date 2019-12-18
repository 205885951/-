using System;
using System.Collections.Generic;
using System.Text;
using  SqlSugar;
namespace hospital.Models
{
   public class BaseModels
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]    //是主键, 还是标识列
        public  int Id { get; set; }
        public DateTime DateTimes { get; set; } = DateTime.Now;
        public  bool IsTrue { get; set; }


    }
}
