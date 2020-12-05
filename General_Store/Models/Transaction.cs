using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General_Store.Models
{
    //This is a joining table. The purpose is to combine data from two (or more) db sets and display them within a joined view
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
        
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}