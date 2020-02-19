using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public interface IReopository<TEnity> where TEnity : class
    {
        TEnity Get(int id);
        IEnumerable<TEnity> GetAll();
        IEnumerable<TEnity> Find(Expression<Func<TEnity, bool>> Predicate);
        void Add(TEnity entity);
        void AddRange(IEnumerable<TEnity> enities);

        void Remove(TEnity entiry);
        void RemoveRange(IEnumerable<TEnity> enities);
    }
}
