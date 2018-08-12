using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLWebsite.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Role { get; set; }

        public Photo Photo { get; set; }
        
        public DateTime DOB { get; set; }

        public ICollection<Project> Projects { get; set; }  

        public ICollection<Course> Courses { get; set; }

        public ICollection<Certificate> Certificates { get; set; }
    }
}
