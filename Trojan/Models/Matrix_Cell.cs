using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trojan.Models
{
    public class Matrix_Cell
    {
        public int Cell_Id { get; set; }
        public int RowId { get; set; }
        public int ColumnId { get; set; }
        public Nullable<bool> value { get; set; }
        public string submatrix { get; set; }
        public int MatrixMatrix_Id { get; set; }
        public string MatrixName { get; set; }

        public virtual Matrix Matrix { get; set; }
    }
}