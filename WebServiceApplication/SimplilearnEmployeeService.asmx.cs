using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceApplication
{
    /// <summary>
    /// Summary description for SimplilearnEmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SimplilearnEmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Employee> GetEmployees()
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee { Name = "Ashbin", Designation = "Archtect" });
            return lst;
        }

        [WebMethod]
        public List<Employee> AddEmployee(string name , string designation)
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee { Name = name, Designation = designation });
            return lst;
        }

    }
}
