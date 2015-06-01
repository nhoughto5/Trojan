//Schema that defines each attribute item added to the virus description 

using System.ComponentModel.DataAnnotations;

namespace Trojan.Models
{
    public class Virus_Item
    {
        [Key]
        public string ItemId { get; set; }

        public string VirusId { get; set; }

        public int Category { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int AttributeId { get; set; }

        public virtual Attribute Attribute { get; set; }

    }
}