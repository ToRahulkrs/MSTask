using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public class Repository<TEnity> : IReopository<TEnity> where TEnity : class
    {
        protected DbContext Context;
        public Repository(EmployeeDBContext context)
        {
            Context = context;
        }
        public void Add(TEnity entity)
        {
            Context.Set<TEnity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEnity> enities)
        {
            Context.Set<TEnity>().AddRange(enities);
        }

        public IEnumerable<TEnity> Find(Expression<Func<TEnity, bool>> Predicate)
        {
            return Context.Set<TEnity>().Where(Predicate);
        }

        public TEnity Get(int id)
        {
            return Context.Set<TEnity>().Find(id);
        }

        public IEnumerable<TEnity> GetAll()
        {
            return Context.Set<TEnity>().ToList();
        }

        public void Remove(TEnity entiry)
        {
            Context.Set<TEnity>().Remove(entiry);
        }

        public void RemoveRange(IEnumerable<TEnity> enities)
        {
            Context.Set<TEnity>().RemoveRange(enities);
        }
    }
}
