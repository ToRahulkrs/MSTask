using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
   public interface IUnitOfWork :IDisposable
    {
        IEmployeeRepository Employees { get; }

        int Complete();
    }
}
