using MSTestEmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public class EmployeeRepository :Repository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBContext context) : base(context) { }

        public void UpdateEmployee(int Id, Employee employee)
        {
            Employee Emp = new Employee();
            Emp.EmpName = employee.EmpName;
            Emp.MobileNumber = employee.MobileNumber;
            Emp.Email = employee.Email;
            Emp.Role = employee.Role;
            employeeDBContext.Employees.Update(employee);
            employeeDBContext.SaveChanges();
            
        }
        public EmployeeDBContext employeeDBContext { get { return Context as EmployeeDBContext; } } 
    }
}
