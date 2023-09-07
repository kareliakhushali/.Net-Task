using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CapstoneDb.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "SubCategory should not be more than 50")]
        public int CatId { get; set; }

        public string Name { get; set; }
    }
}
