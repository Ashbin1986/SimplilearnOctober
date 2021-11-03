using BusinessLayerForMVC.Entities;
using MVCEntityFrameworkApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkApplication.Mappings
{
    public static class EmployeeMapping
    {
        public static List<EmployeeResponseVM> MapEmployeeEntityToResponse(List<EmployeeEntity> entities)
        {
            List<EmployeeResponseVM> employeeResponseVMs = new List<EmployeeResponseVM>();

            foreach (var emp in entities)
            {
                employeeResponseVMs.Add(new EmployeeResponseVM
                {
                    EmployeeId = emp.EmployeeId,
                    EmployeeName = emp.EmployeeName,
                    Project = emp.Project
                });
            }
            return employeeResponseVMs;
        }
    }
}