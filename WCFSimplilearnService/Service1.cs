using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSimplilearnService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Employee> GetData()
        {
            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee { EmpName = "Ashbin Kumar" });
            lstEmp.Add(new Employee { EmpName = "Keff Jhonson" });
            return lstEmp;
        }
    }
}
