using BusinessLayerForMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkApplication.DataAccess
{
    public static class DBHelper
    {
        public static List<EmployeeEntity> GetEmployees()
        {
            List<EmployeeEntity> lstEmployee = new List<EmployeeEntity>();

            string projectName = string.Empty;

            using (Session_23_08_2021DBEntities context = new Session_23_08_2021DBEntities())
            {
                //var employess = context.Employees.Include("Emo_Project_Mapping").ToList();

                var employess = context.Employees.ToList();

                if (employess != null && employess.Count > 0)
                {
                    foreach (var emp in employess)
                    {
                        var ProjectMapping = context.Emo_Project_Mapping.Where(c => c.EmpId == emp.EmployeeId).FirstOrDefault();

                        if (ProjectMapping != null)
                        {
                            projectName = context.Projects.Where(c => c.ProjectId == ProjectMapping.ProjectId).FirstOrDefault().ProjectName;
                        }

                        lstEmployee.Add(new EmployeeEntity { EmployeeId = emp.EmployeeId, EmployeeName = emp.EmployeeName, Project = projectName });
                    }
                }
            }
            return lstEmployee;

        }

        internal static void AddEmployee(EmployeeEntity empRecord)
        {
            using (Session_23_08_2021DBEntities context = new Session_23_08_2021DBEntities())
            {
                context.Employees.Add(new Employee
                {
                    EmployeeName = empRecord.EmployeeName

                });
                context.SaveChanges();
            }
        }

        internal static EmployeeEntity GetEmployeeById(int id)
        {
            using (Session_23_08_2021DBEntities context = new Session_23_08_2021DBEntities())
            {
                var empRecord = context.Employees.Where(c => c.EmployeeId == id).FirstOrDefault();

                if (empRecord != null)
                {
                    return new EmployeeEntity
                    {
                        EmployeeId = empRecord.EmployeeId,
                        EmployeeName = empRecord.EmployeeName
                    };
                }
            }
            return null;
        }

        internal static void UpdateEmployee(EmployeeEntity employeeEntity)
        {
            using (Session_23_08_2021DBEntities context = new Session_23_08_2021DBEntities())
            {
                var empRecord = context.Employees.Where(c => c.EmployeeId == employeeEntity.EmployeeId).SingleOrDefault();

                if (empRecord != null)
                {
                    empRecord.EmployeeName = employeeEntity.EmployeeName;
                    context.SaveChanges();
                }
            }
        }

        internal static void DeleteEmployee(int id)
        {
            using (Session_23_08_2021DBEntities context = new Session_23_08_2021DBEntities())
            {
                var empRecord = context.Employees.Where(c => c.EmployeeId == id).SingleOrDefault();

                if (empRecord != null)
                {
                    context.Employees.Remove(empRecord);
                    context.SaveChanges();
                }
            }
        }
    }
}