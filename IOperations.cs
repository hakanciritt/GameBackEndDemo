using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEndDemo
{
    interface IOperations<T> where T:class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
