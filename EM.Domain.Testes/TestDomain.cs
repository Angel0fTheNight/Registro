using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EM.Domain.Testes
{
    [TestClass]
    public class TestDomain
    {
        Aluno aluno = new Aluno();
        [TestMethod]
        public void TestEquals()
        {
            aluno.Matricula = 13;
            aluno.Equals(aluno.Matricula);

            Assert.AreEqual(aluno.Matricula, aluno.Matricula);
        }
        [TestMethod]
        public void TestGetHashCode()
        {
            aluno.Matricula = 200;
            aluno.Nome = "matheus";
            aluno.Cpf = "";
            aluno.Nascimento = Convert.ToDateTime("11-11-2000");
            aluno.Sexo = (EnumeradorSexo)1;


            Assert.AreNotEqual(aluno.Matricula.GetHashCode(), aluno.Nome.GetHashCode());
        }
        [TestMethod]
        public void TesteToString()
        {
            aluno.Nascimento = Convert.ToDateTime("15-07-2021");

            aluno.Nascimento.ToString("MM/dd/yyyy");

            Assert.AreEqual(aluno.Nascimento.ToString("MM/dd/yyyy"), "07/15/2021");
        }
    }
}
