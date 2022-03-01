using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_1640_Group24.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}