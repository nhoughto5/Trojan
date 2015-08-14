using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trojan.Models
{
    public class Matrix
    {
        public Matrix()
        {
            this.Matrix_Cell = new HashSet<Matrix_Cell>();
            this.Virus = new HashSet<Virus>();
        }

        public int Matrix_Id { get; set; }
        public string name { get; set; }

        public virtual ICollection<Matrix_Cell> Matrix_Cell { get; set; }
        public virtual ICollection<Virus> Virus { get; set; }
    }
}