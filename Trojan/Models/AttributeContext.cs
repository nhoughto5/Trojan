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
        public DbSet<Virus_Item> VirusDescriptionItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}