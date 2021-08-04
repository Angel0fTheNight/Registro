using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using EM.Domain;

namespace EM.Repository
{
    public class RepositorioProfessor : RepositorioAbstratoProfessor<Professor>
    {
        public override void AdicioneNovoProfessor(Professor objto)
        {
            base.AdicioneNovoProfessor(objto);
        }

        public override void AtualizaProfessor(Professor objeto)
        {
            base.AtualizaProfessor(objeto);
        }

        public override void BatePonto(Professor objeto)
        {
            base.BatePonto(objeto);
        }

        public override IEnumerable<Professor> BuscaProfessor()
        {
            return base.BuscaProfessor();
        }

        public override IEnumerable<Professor> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return base.Get(predicate);
        }

        public override void RemoveProfessor(Professor objeto)
        {
            base.RemoveProfessor(objeto);
        }
        public IEnumerable<Professor> BuscarProfessores()
        {
            var professores = new List<Professor>();
            using (FbConnection conexaoFireBird = AcessoFB.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string Consulta = "Select * from Professor ORDER BY Id ASC";
                    FbCommand cmd = new FbCommand(Consulta, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        professores.Add(new Professor()
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Nome = dr["NOME"].ToString(),
                            Materia = dr["MATERIA"].ToString(),
                            Ponto = Convert.ToInt32(dr["PONTOBATIDO"]),
                            Cpf = dr["CPF"].ToString(),

                        }) ;
                    }
                    dr.Close();
                    return professores;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
    public class AcessarFB : Professor, IEntidade<AcessoFB>
    {
        private static readonly AcessarFB instanciaFireBird = new AcessarFB();
        private AcessarFB() { }

        public static AcessarFB GetInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection GetConexao()
        {
            string conn = @"DataSource=localhost; Port=3053; Database=C:\Escola.fb3; username= SYSDBA; password = masterkey";
            return new FbConnection(conn);
        }
    }
}
