using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Group_C_06_SSAC.Models
{
    public class salary
    {
        [Required]
        [Display(Name = "Id")]
        public Int64 id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        public salary()
        {
            date = DateTime.Now;
        }
        [Required]
        [Display(Name = "Date")]
        public DateTime date { get; set; }
        [Display(Name = "Monthly Salary")]
        public Int64 monthly { get; set; }
        [Display(Name = "House rent")]
        public Int64 rent { get; set; }
        [Display(Name = "Bonus")]
        public Int64 bonus { get; set; }
        [Display(Name = "Hospital expense")]
        public Int64 hospital { get; set; }



        [Display(Name = "Recieved Salary")]
        public Int64 recieved { get; set; }



    }
}
