using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_1640_Group24.Models
{
    public class Idea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdeaID { get; set; }
        public string IdeaName { get; set; }
        public DateTime IdeaDateAndTime { get; set; }

        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Display(Name = "UserName")]
        public int UserID { get; set; }
        public int ViewsCount { get; set; }
        public string File { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}