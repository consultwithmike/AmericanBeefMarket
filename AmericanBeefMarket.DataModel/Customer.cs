using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmericanBeefMarket.DataModel
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(36)]
        public string UserId { get; set; }

        /// <summary>
        /// Can be null if there is a UserId associated.
        /// </summary>
        [MaxLength(256), DataType(DataType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// Can be null if there is a UserId associated.
        /// </summary>
        [MaxLength(256), DataType(DataType.MultilineText)]
        public string Address { get; set; }

        /// <summary>
        /// Can be null if there is a UserId associated.
        /// </summary>
        [MaxLength(16), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        /// <summary>
        /// Can be null if there is a UserId associated.
        /// </summary>
        [MaxLength(256), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }
    }
}
