using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_1640_Group24.Models
{
    public class Submission
    {
        public string SubmitID { get; set; }
        public string SubmitName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
   
    }
}