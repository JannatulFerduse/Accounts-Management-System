using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Group_C_06_SSAC.Models
{
    public class payment
    {
            [Required]
            [Display(Name = "Id")]
            public Int64 id { get; set; }
            [Required]
            [Display(Name = "Name")]
            public string name { get; set; }
            public payment()
            {
                date = DateTime.Now;
            }
            [Required]
            [Display(Name = "Date")]
            public DateTime date { get;set; }

            [Display(Name = "Admission Fees")]
            public Int64 admission { get; set; }

            [Display(Name = "Monthly Fees")]
            public Int64 monthly { get; set; }

            [Display(Name = "Examination Fees")]
            public Int64 xam { get; set; }

            [Display(Name = "Tie/Id card/Diary")]
            public Int64 tie { get; set; }

            [Display(Name = "Syllabus")]
            public Int64 syllabus { get; set; }

            [Display(Name = "Sports event")]
            public Int64 sports { get; set; }

            [Display(Name = "Picnic")]
            public Int64 picnic { get; set; }
            [Display(Name = "Due")]
            public Int64 due { get; set; }

    }
}
