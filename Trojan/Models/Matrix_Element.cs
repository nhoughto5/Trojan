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
        [Key, Column(Order = 0)]
        public int RowID;
        [Key, Column(Order = 1)]
        public int ColID;
        public int? cellValue;
        public string R;
    }
}