using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AmericanBeefMarket.DataModel
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(256), DataType(DataType.Text)]
        public string Name { get; set; }

        [Required, Range(0, double.MaxValue), Column(TypeName = "decimal(18,2)"), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required, MaxLength(1024), DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
    }
}
