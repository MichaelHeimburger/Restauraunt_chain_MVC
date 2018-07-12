using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seamus_hut_restauraunt_chain.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public int EmployeePhone { get; set; }
        public int EmployeeNumber { get; set; }
        public int EmergencyContactNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public DateTime DateStarted { get; set; }
    }
}