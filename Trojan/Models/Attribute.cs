using System.ComponentModel.DataAnnotations;

namespace Trojan.Models
{
    public class Attribute
    {
        [ScaffoldColumn(false)]
        public int AttributeID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string AttributeName { get; set; }

        [Required, StringLength(10000), Display(Name = "Attribute Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}