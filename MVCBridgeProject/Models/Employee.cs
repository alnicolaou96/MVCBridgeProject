using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmergencyContactName{ get; set; }
        public string EmergencyContactNumber { get; set; }
        public string DateStarted { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
    }
}