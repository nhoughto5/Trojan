using System.ComponentModel.DataAnnotations;

namespace Trojan.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int AttributeId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

    }
}