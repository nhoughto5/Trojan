using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Trojan.Models
{
    public class TrojanContext : DbContext
    {
        public TrojanContext()
            : base("Trojan")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
    }
}