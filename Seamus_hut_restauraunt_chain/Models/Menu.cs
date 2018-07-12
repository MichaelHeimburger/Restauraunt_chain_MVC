using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seamus_hut_restauraunt_chain.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public double Price { get; set; }
        public string ItemName { get; set; }
    }
}