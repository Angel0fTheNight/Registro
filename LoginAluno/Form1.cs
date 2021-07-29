using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Repository;

namespace LoginAluno
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormAluno vi = new FormAluno();
            RepositorioAluno repositorioAluno = new RepositorioAluno();
            try
            {
                if (repositorioAluno.EntrarNoSistemaComoAluno(txtNome.Text, txtSenha.Text))
                {
                    vi.Preenche(txtNome.Text);
                    this.Hide();
                    vi.ShowDialog();
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
