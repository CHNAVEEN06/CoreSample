using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IEmpRepository
    {
        //get employees
        IEnumerable<Models.Employee> GetEmployees();
        //Get Employee
        Employee GetEmployee(int Eno);
        //delete employee
        int DeleteEmployee(int Eno);
        //add employee
        Employee AddEmployee(Employee employee);
        //update employee
        Employee UpdateEmployee(Employee employee);
    }
}
