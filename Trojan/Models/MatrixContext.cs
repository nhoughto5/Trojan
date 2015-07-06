using System.Data.Entity;
namespace Trojan.Models
{
    public class MatrixContext : DbContext
    {
        public MatrixContext()
            : base("Trojan")
        {
        }
        public DbSet<Matrix_Element> Matrix_Element { get; set; }
    }
}