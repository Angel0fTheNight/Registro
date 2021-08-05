using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class Professor : IEntidade<Professor>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EnumeradorMateria Materia { get; set; }
        public int Ponto { get; set; }
        public string Cpf { get; set; }
    }
}
