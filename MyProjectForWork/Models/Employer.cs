using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProjectForWork.Models
{
    public class Employer
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ShortAbout { get; set; }

        [StringLength(500)]
        public string LongAbout { get; set; }
        public IList<Job> Jobs { get; set; }
        
    }
}