using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trojan.Models
{
    public class Virus
    {
        public int Virus_Id { get; set; }
        public string name { get; set; }
        public int UserUser_Id { get; set; }
        public int Matrix_Matrix_Id { get; set; }

        public virtual Matrix Matrix { get; set; }
        public virtual User User { get; set; }
    }
}