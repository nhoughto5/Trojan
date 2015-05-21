using System.Data.Entity;
namespace Trojan.Models
{
    public class AttributeContext : DbContext
    {
        public AttributeContext()
            : base("Trojan")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
    }
}