using System;
using System.Collections.Generic;

namespace EM.Domain
{
    public class Aluno : IEntidade<Aluno>
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public EnumeradorSexo Sexo { get; set; }
        public override string ToString()
        {
            return Nascimento.ToString("MM/dd/yyyy");
        }
        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Matricula == aluno.Matricula &&
                   Nome == aluno.Nome &&
                   Cpf == aluno.Cpf &&
                   Nascimento == aluno.Nascimento &&
                   Sexo == aluno.Sexo;
        }
        public override int GetHashCode()
        {
            int hashCode = -1709539627;
            hashCode = hashCode * -1521134295 + Matricula.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cpf);
            hashCode = hashCode * -1521134295 + Nascimento.GetHashCode();
            hashCode = hashCode * -1521134295 + Sexo.GetHashCode();
            return hashCode;
        }
    }
}
