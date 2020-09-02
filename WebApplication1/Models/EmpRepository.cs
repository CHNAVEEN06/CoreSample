using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmpRepository : IEmpRepository
    {
        private readonly EmpDbContext context;
        public EmpRepository(EmpDbContext empDbContext)
        {
            this.context = empDbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;

        }

        public int DeleteEmployee(int Eno)
        {
            Employee e1 = context.Employees.Find(Eno);
            context.Remove(e1);
            context.SaveChanges();
            return 1;
        }

        public Employee GetEmployee(int Eno)
        {
            Employee employee = context.Employees.Find(Eno);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = context.Employees.Attach(employee);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employee;
        }
    }
}
