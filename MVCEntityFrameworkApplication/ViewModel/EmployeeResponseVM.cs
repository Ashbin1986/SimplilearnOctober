using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkApplication.ViewModel
{
    public class EmployeeResponseVM
    {
        public int EmployeeId { get; set; }
        
        [Required]
        public string EmployeeName { get; set; }
        public string Project { get; set; }

    }
}