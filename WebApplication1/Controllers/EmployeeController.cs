using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmpRepository _emprepo;
        public EmployeeController(IEmpRepository _emprepo)
        {
            this._emprepo = _emprepo;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Employee> ie = _emprepo.GetEmployees();

            //TempData["ie"] = ie;
            //TempData.Keep();
            return View(ie);
        }





        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Employee employee)
        {
            if (employee != null)
                _emprepo.AddEmployee(employee);
            return RedirectToAction("Index", "Employee");

        }

        public IActionResult Update(int eno)
        {
            Employee employee = new Employee();
            if (eno != 0)
                employee = _emprepo.GetEmployee(eno);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Models.Employee employee)
        {
            if (employee != null)
                _emprepo.UpdateEmployee(employee);
            return RedirectToAction("Employee", "Index");
        }


        [HttpPost]
        public IActionResult Delete(int Eno)
        {
            if (Eno != 0)
                _emprepo.DeleteEmployee(Eno);
            return RedirectToAction("Index", "Employee");
        }

    }
}
