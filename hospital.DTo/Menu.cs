using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
  public  class Menu
    {
        public  int Id { get; set; }
        public  string Type { get; set; }
        public  string Url { get; set; }
        /// <summary>
        /// 父类Id
        /// </summary>
        public  int? PrparentId { get; set; }
        public  DateTime DateTimes { get; set; }
    }
}
