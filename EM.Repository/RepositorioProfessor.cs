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
        public override void AdicioneNovoProfessor(Professor professor)
        {
           using(FbConnection conexaoFirebird = AcessarFB.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string consulta = "INSERT INTO PROFESSOR(ID, NOME, MATERIA, PONTOBATIDOS, CPF) VALUES(" +
                        professor.Id + ",'" + professor.Nome + "','" +Convert.ToInt16(professor.Materia)+"'," + professor.Ponto + ",'" + professor.Cpf + "');";
                    var cmd = new FbCommand(consulta, conexaoFirebird);
                    cmd.ExecuteNonQuery();
                }
                catch(FbException fbx)
                {
                    throw fbx;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }
        public override void RemoveProfessor(Professor professor)
        {
            using (FbConnection conexaoFirebird = AcessarFB.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string comando = "DELETE FROM PROFESSOR WHERE ID = " + professor.Id;
                    var cmd = new FbCommand(comando, conexaoFirebird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbx)
                {
                    throw fbx;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
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
        public override IEnumerable<Professor> Get(Expression<Func<Professor, bool>> predicate) =>
            BuscarTodosProfessores().Where(predicate.Compile());
        public Professor BuscarProfessorPorId(int id) =>
            Get(professor => professor.Id == id).FirstOrDefault();
        public IEnumerable<Professor> BuscarProfessorPorParteDoNome(string parteDoNome) => 
            Get(professor => professor.Nome.ToLower().Contains(parteDoNome.ToLower())).ToList();
        public IEnumerable<Professor> BuscarTodosProfessores()
        {
            var professores = new List<Professor>();
            using (FbConnection conexaoFireBird = AcessarFB.GetInstancia().GetConexao())
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
                            Materia = (EnumeradorMateria)(dr["MATERIA"]),
                            Ponto = Convert.ToInt32(dr["PONTOBATIDOS"]),
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
        public bool CpfJaCadastrado(string cpf, int id) =>
            Get(professor => professor.Id != id && professor.Cpf == cpf).FirstOrDefault() != null;
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
