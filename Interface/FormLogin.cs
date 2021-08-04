﻿using EM.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var formularioAluno = new FormAluno();
            var repositorioAluno = new RepositorioAluno();
            try
            {
                if (repositorioAluno.EntrarNoSistemaComoAluno(txtNome.Text, txtSenha.Text))
                {
                    this.Hide();
                    formularioAluno.Preenche(txtNome.Text);
                    formularioAluno.EstaEmEdicao = true;
                    formularioAluno.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Aluno não esta registrado!");
            }
        }
    }
}
