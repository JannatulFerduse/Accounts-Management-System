using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Group_C_06_SSAC.Models
{
    public class Faculty
    {
        public Faculty()
        {
            date = DateTime.Now;
        }
        [Required]
        [Display(Name = "Id")]
        public Int64 Id { get; set; }
        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Monthly Salary")]
        public Int64 salary { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Joining Date")]
        public DateTime date { get; set; }
    }
}
