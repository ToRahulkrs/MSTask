using MSTestEmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public class EmployeeRepository :Repository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBContext context) : base(context) { }

        public void UpdateEmployee(Employee employee)
        {
            employeeDBContext.Employees.Update(employee);
            employeeDBContext.SaveChanges();   
        }
        public EmployeeDBContext employeeDBContext { get { return Context as EmployeeDBContext; } } 
    }
}
