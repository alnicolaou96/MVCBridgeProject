using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Customer
    {
        [Key]
        public int AddressID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string FavoriteDrink { get; set; }
        public string FavoriteMeal { get; set; }
        public string LargestBill { get; set; }
    }
}