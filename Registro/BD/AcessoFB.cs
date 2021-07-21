using System;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;

namespace Registro
{
    class AcessoFB : Aluno
    {
        private static readonly AcessoFB instanciaFireBird = new AcessoFB();
        private AcessoFB() { }

        public static AcessoFB getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = @"DataSource=localhost; Port=3053; Database=C:\BANCODEDADOS_v3.fb3; username= SYSDBA; password = masterkey";
            return new FbConnection(conn);
        }

        public static DataTable fb_GetDados()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Select * from Aluno";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
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

        public static void fb_InserirDados(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "INSERT into Clientes Values(" + aluno.Matricula + ",'" + aluno.Nome + "','" + aluno.Cpf + "','" +
 aluno.Nascimento + "','" + aluno.Sexo + "')";

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
        public static void fb_ExcluirDados(int matricula)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "DELETE from Aluno Where Matricula= " + matricula;
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
                        aluno.Sexo = Convert.ToInt32(dr[4]);
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
        public static void fb_AlterarDados(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Update Clientes set nome= '" + aluno.Nome + "', Cpf= '" + aluno.Cpf +
                                           "', Nascimento = '" + aluno.Nascimento + "', Sexo= '" + aluno.Sexo + "'" + " Where Matricula= " + aluno.Matricula;
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
    }

}
