using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Trojan.Models
{
    public class Matrix_Element
    {
        [Key]
        public int RowNo;

        [Key]
        public int ColNo;

        public int? cellValue;
    }
}