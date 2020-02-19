using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly EmployeeDBContext _context;
        public UnitOfWork(EmployeeDBContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
        }

        public IEmployeeRepository Employees { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
