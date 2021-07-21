using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using EM.Domain;
using System.Data;

namespace EM.Repository
{
    public class AcessoF : Aluno, IEntidade<AcessoFB>
    {
        private static readonly AcessoF instanciaFireBird = new AcessoF();
        private AcessoF() { }

        public static AcessoF getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = @"DataSource=localhost; Port=3053; Database=C:\BANCODEDADOS_v3.fb3; username= SYSDBA; password = masterkey";
            return new FbConnection(conn);
        }
        

 
       

        public static Aluno fb_ProcuraDados(int matricula)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Select * from Aluno Where Matricula = " + matricula;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Aluno aluno = new Aluno();
                    while (dr.Read())
                    {
                        aluno.Matricula = Convert.ToInt32(dr[0]);
                        aluno.Nome = dr[1].ToString();
                        aluno.Cpf = dr[2].ToString();
                        aluno.Nascimento = Convert.ToDateTime(dr[3]);
                        aluno.Sexo = (EnumeradorSexo)dr[4];
                    }
                    return aluno;
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
        public static IEnumerable<Aluno> fb_ProcuraDadosNome(string nomes)
        {
            List<Aluno> alunos = new List<Aluno>(); 
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string consulta = "Select * from Aluno Where Nome like '%" + nomes + "'";
                    FbCommand cmd = new FbCommand(consulta, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Aluno aluno = new Aluno();
                    while (dr.Read())

                    {
                        alunos.Add(new Aluno()
                        {
                            Matricula = Convert.ToInt32(dr[0]),
                            Nome = dr[1].ToString(),
                            Cpf = dr[2].ToString(),
                            Nascimento = Convert.ToDateTime(dr[3]),
                            Sexo = (EnumeradorSexo)dr[4]
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
        
    }
}
