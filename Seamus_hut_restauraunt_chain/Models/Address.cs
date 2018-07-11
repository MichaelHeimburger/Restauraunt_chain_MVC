using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seamus_hut_restauraunt_chain.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}