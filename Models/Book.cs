using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }
    }
}

