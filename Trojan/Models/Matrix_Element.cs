using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trojan.Models
{
    public class Matrix_Element
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ElementID;
        public int RowID;
        public int ColID;
        public int? cellValue;
        public string R;
    }
}