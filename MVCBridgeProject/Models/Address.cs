using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public int StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }

    }
}