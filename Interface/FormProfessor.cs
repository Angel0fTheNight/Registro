using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EM.Repository;
using EM.Domain;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormProfessor : Form
    {
        BindingSource bs = new BindingSource();
        public void Limpar()
        {
            txtCpf.Clear();
            txtId.Clear();
            txtNome.Clear();
            cboMateria.SelectedIndex = -1;
        }
        private void UseApenasNumeros(KeyPressEventArgs e) =>
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 08);
        private void UseApenasLetras(KeyPressEventArgs e) =>
            e.Handled = (char.IsDigit(e.KeyChar));
        private bool CampoVazio(string campo) =>
           campo == string.Empty;
        public FormProfessor()
        {
            InitializeComponent();
        }
        public Professor PegarDadosProfessor()
        {
            var professor = new Professor();
            professor.Id = Convert.ToInt32(txtId.Text);
            professor.Nome = txtNome.Text.Trim();
            professor.Materia = (EnumeradorMateria)cboMateria.SelectedIndex;
            professor.Cpf = txtCpf.Text;
            professor.Ponto = 0;
            return professor;
        }
        public void PreencheTabela(Professor professor)
        {
            txtNome.Text = professor.Nome;
            txtId.Text = professor.Id.ToString();
            txtCpf.Text = professor.Cpf;
            cboMateria.SelectedIndex = (int)professor.Materia;
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }
        private void PreencheGrid()
        {
            try
            {
                var repositorioProfessor = new RepositorioProfessor();
                bs.DataSource = repositorioProfessor.BuscarTodosProfessores();
                dgvProfessor.DataSource = bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Erro");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Validacao())
            {
                return;
            }
            try
            {
                var repositorioProfessor = new RepositorioProfessor();
                repositorioProfessor.AdicioneNovoProfessor(PegarDadosProfessor());
                PreencheGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Validacao() =>
           ProcessoDeValidacao(CampoVazio(txtNome.Text.Trim()), "O campo Nome esta vazio! O campo Nome é um campo obrigatorio!", txtNome) ?
               false :
           ProcessoDeValidacao(CampoVazio(txtId.Text), "O campo Matricula esta vazio! O campo Matricula é um campo obrigatorio!", txtId) ?
               false :
           ProcessoDeValidacao(!ValidarCpf.IsCpf(txtCpf.Text) && txtCpf.Text != string.Empty, "CPF invalido!", txtCpf) ?
               false :
           ProcessoDeValidacao(new RepositorioProfessor().CpfJaCadastrado(txtCpf.Text, Convert.ToInt32(txtId.Text)) && !CampoVazio(txtCpf.Text), "CPF ja cadastrado!", txtCpf) ?
               false : true;
        private bool ProcessoDeValidacao(bool consistencia, string mensagem, Control controleFocus)
        {
            if (consistencia)
            {
                Atencao(mensagem);
                controleFocus.Focus();
            }
            return consistencia;
        }
        private static void Atencao(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

        private void dgvProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var professor = new Professor();
            var repositorioProfessor = new RepositorioProfessor();
            professor = repositorioProfessor.BuscarProfessorPorId(Convert.ToInt32(dgvProfessor.Rows[e.RowIndex].Cells[0].Value));
            PreencheTabela(professor);
        }

        private void btnDeletarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                var repositorioProfessor = new RepositorioProfessor();
                repositorioProfessor.RemoveProfessor(PegarDadosProfessor());
                PreencheGrid();
                Limpar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseApenasNumeros(e);
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseApenasNumeros(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseApenasLetras(e);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (CampoVazio(txtPesquisa.Text))
            {
                PreencheGrid();
            }
            try
            {
                var repositorioProfessor = new RepositorioProfessor();
                string resultado = txtPesquisa.Text;
                if (int.TryParse(resultado, out int id))
                {
                    bs.DataSource = repositorioProfessor.BuscarProfessorPorId(id);
                    dgvProfessor.DataSource = bs;
                }
                else
                {
                    var alunos = (List<Professor>)repositorioProfessor.BuscarProfessorPorParteDoNome(resultado);
                    bs.DataSource = alunos;
                    dgvProfessor.DataSource = bs;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na consulta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
