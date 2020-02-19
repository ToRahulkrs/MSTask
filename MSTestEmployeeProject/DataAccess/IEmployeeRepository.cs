using MSTestEmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public interface IEmployeeRepository : IReopository<Employee>
    {
        void UpdateEmployee(Employee employee);
    }
}
