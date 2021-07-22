using EM.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EM.Repository.Testes
{
    [TestClass]
    public class TesteRepositorio
    {
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        

        [TestMethod]
        public void TestesAdd()
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = 200;
            aluno.Nome = "matheus";
            aluno.Cpf = "";
            aluno.Nascimento = Convert.ToDateTime("11-11-2000");
            aluno.Sexo = (EnumeradorSexo)0;

            repositorioAluno.AdicioneNovoAluno(aluno);

            Assert.AreEqual(aluno, repositorioAluno.BusqueAlunosPorMatricula(200));         
        }
        [TestMethod]
        public void TestesUpdate()
        {
            Aluno alunoUpdate = new Aluno();
            alunoUpdate = repositorioAluno.BusqueAlunosPorMatricula(200);

            alunoUpdate.Cpf = "52371855251";

            repositorioAluno.AtualizeAluno(alunoUpdate);
            Assert.AreEqual(alunoUpdate, repositorioAluno.BusqueAlunosPorMatricula(200));
        }
        [TestMethod]
        public void TestesRemove()
        {
            Aluno alunoRemove = new Aluno();
            alunoRemove = repositorioAluno.BusqueAlunosPorMatricula(200);

            repositorioAluno.RemovaAluno(alunoRemove);

            Assert.IsNotNull(alunoRemove);
        }
        [TestMethod]
        public void TestesGetAll()
        {
            Assert.IsNotNull(repositorioAluno.BusqueTodosOsAlunos());            
        }
        [TestMethod]
        public void TestesGetByMatricula()
        {
            Aluno alunoGetByMatricula = new Aluno();
            int matricula = 1;
            alunoGetByMatricula = repositorioAluno.BusqueAlunosPorMatricula(matricula);

            Assert.AreEqual(alunoGetByMatricula, repositorioAluno.BusqueAlunosPorMatricula(matricula));
        }
        [TestMethod]
        public void TestesGetByContendoNome()
        {
            List<Aluno> alunoGetByCondendoNome = new List<Aluno>();
            string nome = "M";
            alunoGetByCondendoNome = (List<Aluno>)repositorioAluno.BusqueAlunosPorParteDoNome(nome);

            Assert.IsNotNull(alunoGetByCondendoNome);
        }
        [TestMethod]
        public void TestesGet()
        {
            int matricula = 20;

            Assert.IsNotNull(repositorioAluno.Get(aluno => aluno.Matricula == matricula));
        }

    }
}
