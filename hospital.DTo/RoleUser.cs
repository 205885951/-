using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.DTo
{
  public  class RoleUser
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  int RoleId { get; set; }
        public  string RoleName { get; set; }
        public  int AdminUserId { get; set; }
        public  string Account { get; set; }
    }
}
