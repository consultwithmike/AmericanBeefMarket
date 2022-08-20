using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace AmericanBeefMarket.DataModel
{
    [Index(nameof(CustomerId)), Index(nameof(UserId)), Index(nameof(ShippingEmail)), Index(nameof(ShippingPhone))]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets found or created when saving the order
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Can be null if checking out as a guest
        /// </summary>
        [MaxLength(36)]
        public string UserId { get; set; }

        /// <summary>
        /// Can be null if same as shipping.
        /// </summary>
        [MaxLength(256), DataType(DataType.Text)]
        public string BillingName { get; set; }

        /// <summary>
        /// Can be null if same as shipping.
        /// </summary>
        [MaxLength(256), DataType(DataType.MultilineText)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Can be null if same as shipping.
        /// </summary>
        [MaxLength(16), DataType(DataType.PhoneNumber)]
        public string BillingPhone { get; set; }

        /// <summary>
        /// Can be null if same as shipping.
        /// </summary>
        [MaxLength(256), DataType(DataType.EmailAddress)]
        public string BillingEmail { get; set; }

        [Required, MaxLength(256), DataType(DataType.Text)]
        public string ShippingName { get; set; }

        [Required, MaxLength(256), DataType(DataType.MultilineText)]
        public string ShippingAddress { get; set; }

        [Required, MaxLength(16), DataType(DataType.PhoneNumber)]
        public string ShippingPhone { get; set; }

        [Required, MaxLength(256), DataType(DataType.EmailAddress)]
        public string ShippingEmail { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }

        public Customer Customer { get; set; }

        public IList<OrderItem> Items { get; set; }
    }
}
