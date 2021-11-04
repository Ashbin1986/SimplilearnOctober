using BusinessLayerForMVC.Entities;
using MVCEntityFrameworkApplication.DataAccess;
using MVCEntityFrameworkApplication.Mappings;
using MVCEntityFrameworkApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameworkApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = EmployeeMapping.MapEmployeeEntityToResponse(DBHelper.GetEmployees());

            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employeeEntity = DBHelper.GetEmployeeById(id);

            return View(new EmployeeResponseVM
            {
                EmployeeName = employeeEntity.EmployeeName,
                EmployeeId = employeeEntity.EmployeeId,
                Project = employeeEntity.Project
            });
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View(new EmployeeResponseVM());
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult AddEmployee(EmployeeResponseVM employeeResponseVM)
        {
            try
            {
                var empRecord = new EmployeeEntity()
                {
                    EmployeeName = employeeResponseVM.EmployeeName
                };

                DBHelper.AddEmployee(empRecord);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employeeEntity = DBHelper.GetEmployeeById(id);

            return View(new EmployeeResponseVM
            {
                EmployeeName = employeeEntity.EmployeeName,
                EmployeeId = employeeEntity.EmployeeId,
                Project = employeeEntity.Project
            });
        }



        // POST: Employee/Edit/5
        [HttpPost]

        public ActionResult Edit(int id, FormCollection collection)
        {
            string str = "10";

            int x = int.Parse(str);
            try
            {
                // TODO: Add update logic here
                EmployeeEntity employeeEntity = new EmployeeEntity
                {
                    EmployeeId = id,
                    EmployeeName = collection.Get("EmployeeName")
                };

                DBHelper.UpdateEmployee(employeeEntity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        [NonAction]
        public ActionResult Delete(int id)
        {
            var employeeEntity = DBHelper.GetEmployeeById(id);

            return View(new EmployeeResponseVM
            {
                EmployeeName = employeeEntity.EmployeeName,
                EmployeeId = employeeEntity.EmployeeId,
                Project = employeeEntity.Project
            });
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                DBHelper.DeleteEmployee(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
