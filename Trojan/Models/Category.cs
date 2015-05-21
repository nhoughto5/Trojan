using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trojan.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Attribute Description")]
        public string Description { get; set; }

        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}