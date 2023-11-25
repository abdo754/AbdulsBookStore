using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbdulsBooks.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [Display(Name = "CoverType Name")]
     
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
