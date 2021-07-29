using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace EM.Repository
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade<T>
    {
        public virtual void AdicioneNovoAluno(T objeto)
        {

        }
        public virtual void RemovaAluno(T objeto)
        {

        }
        public virtual void AtualizeAluno(T objeto)
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
