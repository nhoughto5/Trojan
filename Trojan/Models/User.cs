using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trojan.Models
{
    public class User
    {
        public User()
        {
            this.Virus = new HashSet<Virus>();
        }

        public int User_Id { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public virtual ICollection<Virus> Virus { get; set; }
    }
}