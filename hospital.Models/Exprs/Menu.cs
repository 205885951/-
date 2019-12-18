using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 菜 单 
    /// </summary>
    public class Menu:BaseModels
    {
        public  string Type { get; set; }
        public  string Url { get; set; }
        public  int? PrparentId { get; set; }
    }
}
