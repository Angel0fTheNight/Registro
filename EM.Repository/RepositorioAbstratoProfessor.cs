using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace EM.Repository
{
    public abstract class RepositorioAbstratoProfessor<T> where T : IEntidade<T>
    {
        public virtual void AdicioneNovoProfessor(T objto)
        {

        }
        public virtual void RemoveProfessor(T objeto)
        {

        }
        public virtual void BatePonto(T objeto)
        {

        }
        public virtual void AtualizaProfessor(T objeto)
        {

        }
        public virtual IEnumerable<T> BuscaProfessor()
        {
            return null;
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return null;
        }

        internal IEnumerable<Professor> Get(Expression<Func<Aluno, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
