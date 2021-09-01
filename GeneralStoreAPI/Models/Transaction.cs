using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        // (assumed by EF) [Key]
        public int Id { get; set; }
        [Required]
        // (assumed by EF) [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime DateOfTransaction { get; set; }
        public int Quantity { get; set; }
    }
}