using SimpliLearnWebServiceClient.EmployeeServiceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SimpliLearnWebServiceClient
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //EmployeeServiceApp.SimplilearnEmployeeServiceSoapClient employeeServiceClient = new EmployeeServiceApp.SimplilearnEmployeeServiceSoapClient();
            //var empList = employeeServiceClient.GetEmployees().ToList();

        }

        protected void AddEmployee_Click(object sender, EventArgs e)
        {
            //WCF

            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            ServiceReference1.Employee[] emp = service1Client.GetData();

            string str ="33";

            //ASMX
            //EmployeeServiceApp.SimplilearnEmployeeServiceSoapClient employeeServiceClient = new EmployeeServiceApp.SimplilearnEmployeeServiceSoapClient();
            //var empList = employeeServiceClient.AddEmployee(txtName.Text, txtDesgnation.Text);

            //CalculatorService.CalculatorSoapClient calculatorSoapClient = new CalculatorService.CalculatorSoapClient();

            //int result = calculatorSoapClient.Add(100, 400);
            //Response.Write("Response from Calculator Service- Addition : " + result);

        }
    }
}