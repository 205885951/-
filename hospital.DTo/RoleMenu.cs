using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
  public  class RoleMenu
    {
        public  int Id { get; set; }
        public  int MenId { get; set; }
        public  string MenName { get; set; }
        public  string Url { get; set; }
        public  int RoleId { get; set; }

        public string RoleName
        {
            get;
            set;
        }
    }
}
