using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AmericanBeefMarket.DataModel
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required, Range(0, double.MaxValue)]
        public int Quantity { get; set; }

        [Required, Range(0, double.MaxValue), DataType(DataType.Currency), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Order Order { get; set; }

        public Item Item { get; set; }
    }
}
