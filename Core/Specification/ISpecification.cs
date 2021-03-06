using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public interface ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get;}

        public List<Expression<Func<T, object>>> Includes { get;}
         
    }
}