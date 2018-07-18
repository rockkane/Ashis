using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<Employee> employeelist = db.Employees.ToList();

            EmployeeViewModel employeeVM = new EmployeeViewModel();

            List<EmployeeViewModel> employeeVMlist = employeelist.Select(x => new EmployeeViewModel
            { Name = x.Name,
                Address = x.Address,
                DepartmentId = x.DepartmentId,
                EmployeeId = x.EmployeeId,
                DepartmentName=x.Department.DepartmentName}).ToList();

            return View(employeeVMlist);
        }
    }
}