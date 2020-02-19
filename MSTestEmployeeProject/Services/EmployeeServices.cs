using MSTestEmployeeProject.DataAccess;
using MSTestEmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.Services
{
    public class EmployeeServices
    {
        public readonly UnitOfWork _unitOfWork;
        public EmployeeServices()
        {
            _unitOfWork = new UnitOfWork(new EmployeeDBContext());
        }
        
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _unitOfWork.Employees.GetAll();
        }

        public void InserEmployee(Employee employee)
        {
            if (employee != null)
            {
                _unitOfWork.Employees.Add(employee);
                _unitOfWork.Complete();
            }
        }

        public Employee GetEmployeeById(int id)
        {
           return _unitOfWork.Employees.Get(id);
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            var emp = _unitOfWork.Employees.Get(id);
            if (emp != null)
            {
                emp.EmpName = employee.EmpName??employee.EmpName;
                emp.Email = employee.Email??emp.Email;
                emp.MobileNumber = employee.MobileNumber ?? emp.MobileNumber;
                emp.Role = employee.Role??emp.Role;
            }
            _unitOfWork.Employees.UpdateEmployee(emp);
            _unitOfWork.Complete();

        }

        public void DeleteEmployee(int id)
        {
            var data = _unitOfWork.Employees.Get(id);
            if (data != null)
            {
                _unitOfWork.Employees.Remove(data);
                _unitOfWork.Complete();
            }
          
        }

    }
}
