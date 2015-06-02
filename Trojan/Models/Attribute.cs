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

        [Display(Name = "F_in")]
        public int F_in { get; set; }

        [Display(Name = "F_out")]
        public int F_out { get; set; }

        [Display(Name = "F_sum")]
        public int F_sum { get; set; }

        public int? CategoryID { get; set; }

        public string CategoryName { get; set; }

        public virtual Category Category { get; set; }
    }
}