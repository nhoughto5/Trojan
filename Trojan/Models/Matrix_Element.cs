using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trojan.Models
{
    public class Matrix_Element
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RowID { get; set; }
        public int ColID { get; set; }
        public int? cellValue { get; set; }
        public string R { get; set; }
    }
}