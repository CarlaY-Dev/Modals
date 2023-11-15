using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modals.Models
{
    public class Person
    {  
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string Name { get; set; }
        public int Age { get; set; }

    }
}