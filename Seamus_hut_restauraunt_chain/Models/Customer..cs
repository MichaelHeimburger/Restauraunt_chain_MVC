using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seamus_hut_restauraunt_chain.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }
        public string FavoriteDrink { get; set; }
        public string FavoriteMeal { get; set; }
        public int LongestBill { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public virtual Address Address{ get; set; }
    }
}