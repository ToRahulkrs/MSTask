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
    }
}
