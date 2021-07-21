using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Registro
{

    public partial class Form1 : Form
    {
        private void preencheGrid()
        {
            try
            {
                dataGridView1.DataSource = AcessoFB.fb_GetDados().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void comboBSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBNome_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonAdcionar_Click(object sender, EventArgs e)
        {
            ValidacaoDeCampos validacao = new ValidacaoDeCampos();
 
            if (validacao.CampoVazio(textBNome.Text))
            {
                MessageBox.Show("O campo Nome esta vazio! O campo Nome é um capo obrigatorio!");
            }
           
            if (!ValidarCpf.IsCpf(textBCpf.Text) && textBCpf.Text != string.Empty)
            {
                    MessageBox.Show("CPF invalido");
            }

            if (validacao.CampoVazio(textBMatricula.Text))
            {
                MessageBox.Show("O campo Matricula esta vazio! O campo Matricula é um capo obrigatorio!");
            }

            if (validacao.CampoVazio(maskedTBNascimento.Text))
            {
                MessageBox.Show("O campo Nascimento esta vazio! O campo Nascimento é um capo obrigatorio!");
            }

            if (comboBSexo.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Sexo não foi selecionado! O campo Sexo é um capo obrigatorio!");
            }
            DateTime dataValida;
            DateTime dataHoje = DateTime.Today;
            if (!DateTime.TryParse(maskedTBNascimento.Text, out dataValida) || dataHoje < Convert.ToDateTime(maskedTBNascimento.Text) || 1850 >= Convert.ToDateTime(maskedTBNascimento.Text).Year)
            {
                MessageBox.Show("Data Invalida");
            }

        }

        private void textBMatricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBCpf.Text = string.Empty;
            textBMatricula.Text = string.Empty;
            textBNome.Text = string.Empty;
            maskedTBNascimento.Text = string.Empty;
            comboBSexo.SelectedIndex = -1; 
        }

        private void maskedTBNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void comboBSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBCpf_Leave(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonPesquisae_Click(object sender, EventArgs e)
        {
           
                int codigo = Convert.ToInt32(textBPesquisa.Text);
                Aluno alunos = new Aluno();
                try
                {
                    alunos = AcessoFB.fb_ProcuraDados(codigo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                }
                preencheDados(alunos);
        }
        private void preencheDados(Aluno alun)
        {
            
            textBMatricula.Text = alun.Matricula.ToString();
            textBNome.Text = alun.Nome;
            textBCpf.Text = alun.Cpf;
            maskedTBNascimento.Text = alun.Nascimento.ToString();
            comboBSexo.SelectedIndex = alun.Sexo;         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
