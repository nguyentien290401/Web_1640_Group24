using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web_1640_Group24.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDateAndTime { get; set; }
        public int IdeaID { get; set; }
        public int UserID { get; set; }
    }
}