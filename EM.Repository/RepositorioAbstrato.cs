using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace EM.Repository
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade<T>
    {
        public virtual void Add(T objeto)
        {

        }

        public virtual void RemovaOsAlunos(T objeto)
        {

        }

        public virtual void AtualizeOsAlunos(T objeto)
        {

        }

        public virtual IEnumerable<T> BusqueTodosOsAlunos()
        {
            return null;
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return null;
        }

    }
}
