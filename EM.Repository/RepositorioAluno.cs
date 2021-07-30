using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using FirebirdSql.Data.FirebirdClient;
using System.Linq.Expressions;

namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public bool ProcureCpfJaCadastrado(string cpf, int matricula) => Get(aluno => aluno.Cpf == cpf && aluno.Matricula != matricula).FirstOrDefault() != null;           
        public bool ProcureMatriculaJaCadastrada(int matricula) => BusqueAlunosPorMatricula(matricula) != null;
        public override void AdicioneNovoAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFB.GetInstancia().GetConexao())
            {
                try
                    {
                    conexaoFireBird.Open();
                    string mSQL = "INSERT into Aluno(Matricula, Nome, Cpf, Nascimento, Sexo) Values(" + aluno.Matricula + ",'" + aluno.Nome + "','" + aluno.Cpf + "','" +
    aluno.Nascimento.ToString("MM/dd/yyyy") + "','" + Convert.ToInt64(aluno.Sexo) + "')";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
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
        public override void RemovaAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFB.GetInstancia().GetConexao())
            {
                
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE from Aluno Where Matricula= " + aluno.Matricula;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
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
        public override void AtualizeAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFB.GetInstancia().GetConexao())
            {               
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Update Aluno set nome= '" + aluno.Nome + "', Cpf= '" + aluno.Cpf +
                                           "', Nascimento = '" + aluno.Nascimento.ToString("MM/dd/yyyy") + "', Sexo= '" + Convert.ToInt64(aluno.Sexo) + "'" + " Where Matricula= " + aluno.Matricula;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
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
        public override IEnumerable<Aluno> BusqueTodosOsAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            using (FbConnection conexaoFireBird = AcessoFB.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string Consulta = "Select * from Aluno ORDER BY Matricula ASC";
                    FbCommand cmd = new FbCommand(Consulta, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        alunos.Add(new Aluno()
                        {
                            Matricula = Convert.ToInt32(dr["MATRICULA"]),
                            Nome = dr["NOME"].ToString(),
                            Cpf = dr["CPF"].ToString(),
                            Nascimento = Convert.ToDateTime(dr["NASCIMENTO"]),
                            Sexo = ((EnumeradorSexo)(int)dr["SEXO"])

                        }) ;
                    }
                    dr.Close();
                    return alunos;
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
        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return BusqueTodosOsAlunos().Where(predicate.Compile());
        }
        public Aluno BusqueAlunosPorMatricula(int matricula)
        {
            try
            {
                return Get(aluno => aluno.Matricula ==  matricula).FirstOrDefault();
            }
            catch (Exception fbex)
            {
                throw fbex;
            }
        }
        public Aluno BusqueAlunoPorNome(string nome)
        {
            try
            {
                return Get(aluno => aluno.Nome.ToLower().Contains(nome.ToLower())).First();
            }
            catch (Exception fbex)
            {
                throw fbex;
            }
        }
        public bool EntrarNoSistemaComoAluno(string nome, string senha) => Get(alun => alun.Nome.ToLower() == nome.ToLower() && alun.Cpf == senha).First() != null;      
        public IEnumerable<Aluno> BusqueAlunosPorParteDoNome(string parteDoNome)
        {            
            try
            {
                return Get(aluno => aluno.Nome.ToLower().Contains(parteDoNome.ToLower())).ToList();
            }
            catch (Exception fbex)
            {
                throw fbex;
            }                           
        }    
    }
    public class AcessoFB : Aluno, IEntidade<AcessoFB>
    {
        private static readonly AcessoFB instanciaFireBird = new AcessoFB();
        private AcessoFB() { }

        public static AcessoFB GetInstancia()
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
