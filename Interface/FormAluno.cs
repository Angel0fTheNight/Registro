using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;

namespace Interface
{
    public partial class FormAluno : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }
        private void PreencheGrid()
        {
            try
            {
                RepositorioAluno dadosAlunos = new RepositorioAluno();
                bs.DataSource = dadosAlunos.BusqueTodosOsAlunos();
                dgvAluno.DataSource = bs;
                dgvAluno.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        private void PreencheDados(Aluno alun)
        {
            textBMatricula.Text = alun.Matricula.ToString();
            textBNome.Text = alun.Nome;
            textBCpf.Text = alun.Cpf;
            maskedTBNascimento.Text = Convert.ToString(alun.Nascimento);
            comboBSexo.SelectedIndex = (int)alun.Sexo;
        }
        public void Preenche(string nome)
        {
            RepositorioAluno aluno = new RepositorioAluno();
            PreencheDados((Aluno)aluno.BusqueAlunoPorNome(nome));
        }
        private BindingSource bs = new BindingSource();
        public void LimpeOsCampos()
        {
            textBCpf.Text = string.Empty;
            textBMatricula.Text = string.Empty;
            textBNome.Text = string.Empty;
            maskedTBNascimento.Text = string.Empty;
            comboBSexo.SelectedIndex = -1;
            textBPesquisa.Text = string.Empty;
            dgvAluno.ClearSelection();
        }
        private bool _EstaEmEdicao;
        public bool EstaEmEdicao
        {
            get
            {
               return _EstaEmEdicao;
            }
            set 
            {
                _EstaEmEdicao = value;
                buttonAdicionar.Text = _EstaEmEdicao ? "Modificar" : "Adcionar";
                buttonLimpar.Text = _EstaEmEdicao ? "Cancelar" : "Limpar";
                groupBCadEditAluno.Text = _EstaEmEdicao ? "Editando Aluno" : "Novo Aluno";
                textBMatricula.Enabled = !_EstaEmEdicao
            ;}
        }
        public FormAluno()
        {
            InitializeComponent();
            textBNome.MaxLength = 100;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
                return;
            }
            var aluno = new Aluno();
            aluno.Matricula = Convert.ToInt32(textBMatricula.Text);
            aluno.Nome = textBNome.Text.Trim();
            aluno.Cpf = textBCpf.Text;
            aluno.Nascimento = Convert.ToDateTime(maskedTBNascimento.Text);
            aluno.Sexo = (EnumeradorSexo)comboBSexo.SelectedIndex;
            var dadosAluno = new RepositorioAluno();
            if (!EstaEmEdicao)
            {
                try
                {
                    dadosAluno.AdicioneNovoAluno(aluno);
                    PreencheGrid();
                    MessageBox.Show("Aluno inserido com sucesso !", "Sucesso", MessageBoxButtons.OK);
                    LimpeOsCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro no cadastro, algum dos campos esta inserido de maneira incorreta!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    dadosAluno.AtualizeAluno(aluno);
                    PreencheGrid();
                    MessageBox.Show("Aluno modificado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    LimpeOsCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na modificação, algum dos campos esta inserido de maneira incorreta!", "Erro", MessageBoxButtons.OK);
                }
               
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpeOsCampos();

            if (EstaEmEdicao)
            {
                MessageBox.Show("A edição do aluno foi cancelada");
                EstaEmEdicao = false;
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            RepositorioAluno repositorioAluno = new RepositorioAluno();
            string resultado = textBPesquisa.Text;

            if (int.TryParse(resultado, out int matricula))
            {
                try
                {
                    bs.DataSource = repositorioAluno.BusqueAlunosPorMatricula(matricula);
                    dgvAluno.DataSource = bs;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na consulta!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                var alunos = (List<Aluno>)repositorioAluno.BusqueAlunosPorParteDoNome(resultado);
                try
                {
                    bs.DataSource = alunos;
                    dgvAluno.DataSource = bs;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na consulta!", "Erro", MessageBoxButtons.OK);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EstaEmEdicao = !EstaEmEdicao;
            dgvAluno.ClearSelection();
           
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var dadosAlunos = new RepositorioAluno();
                var aluno = dadosAlunos.BusqueAlunosPorMatricula(Convert.ToInt32(textBMatricula.Text));
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Excluir aluno", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        dadosAlunos.RemovaAluno(aluno);
                        PreencheGrid();
                        MessageBox.Show("Aluno excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                        LimpeOsCampos();                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um aluno para excluí-lo!", "Erro", MessageBoxButtons.OK);
            }
        }
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 08);
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 08);
        }
        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioAluno dadosAlunos = new RepositorioAluno();
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                if (EstaEmEdicao)
                {
                    var aluno = new Aluno();
                    try
                    {
                        int codigo = Convert.ToInt32(dgvAluno.Rows[e.RowIndex].Cells[0].Value);
                        aluno = dadosAlunos.BusqueAlunosPorMatricula(codigo);
                        textBMatricula.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    PreencheDados(aluno);
                }
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (CampoVazio(textBPesquisa.Text))
            {
                PreencheGrid();
                textBMatricula.Enabled = true;
            }
        }
        private void dgvAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != string.Empty)
            {
                string cpf = e.Value.ToString();

                cpf = string.Format("{0}.{1}.{2}-{3}",
                                    cpf.Substring(0, 3),
                                    cpf.Substring(3, 3),
                                    cpf.Substring(6, 3),
                                    cpf.Substring(9, 2));
                e.Value = cpf;
                e.FormattingApplied = true;
            }
        }
        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            var repositorioAluno = new RepositorioAluno();
            if (!CampoVazio(textBMatricula.Text))
            {
                int matricula = Convert.ToInt32(textBMatricula.Text);
                if (matricula == 0 || textBMatricula.Text.Contains("-"))
                {
                    MessageBox.Show("Número de matricula invalido!\nA matricula deve ser positiva e diferente de 0", "Erro");
                    textBMatricula.Clear();
                }
                if (repositorioAluno.ProcureMatriculaJaCadastrada(matricula))
                {
                    MessageBox.Show("Número de matricula ja cadastrado!", "Erro");
                    textBMatricula.Clear();
                }
            }
        }
        public bool CampoVazio(string campo) => campo == string.Empty;
        private void btnSair_Click(object sender, EventArgs e) => Close();
        private bool Validacao()
        {
            if (CampoVazio(textBNome.Text.Trim()))
            {
                MessageBox.Show("O campo Nome esta vazio! O campo Nome é um campo obrigatorio!", "Erro");
                textBNome.Clear();
                return true;
            }
            if (CampoVazio(textBMatricula.Text))
            {
                MessageBox.Show("O campo Matricula esta vazio! O campo Matricula é um campo obrigatorio!", "Erro");
                return true;
            }
            if (CampoVazio(maskedTBNascimento.Text) || !maskedTBNascimento.MaskCompleted)
            {
                MessageBox.Show("O campo Nascimento esta vazio ou incompleto! O campo Nascimento é um campo obrigatorio!", "Erro");
                return true;
            }
            if (comboBSexo.SelectedIndex != 0 && comboBSexo.SelectedIndex != 1)
            {
                MessageBox.Show("O campo Sexo não foi selecionado! O campo Sexo é um campo obrigatorio!", "Erro");
                return true;
            }
            DateTime dataHoje = DateTime.Today;
            if (!DateTime.TryParse(maskedTBNascimento.Text, out _) || dataHoje <= Convert.ToDateTime(maskedTBNascimento.Text))
            {
                MessageBox.Show("Data Invalida", "Erro");
                return true;
            }
            if (!ValidarCpf.IsCpf(textBCpf.Text) && textBCpf.Text != string.Empty)
            {
                MessageBox.Show("CPF invalido", "Erro");
                return true;
            }
            var dadosAluno = new RepositorioAluno();
            if (dadosAluno.ProcureCpfJaCadastrado(textBCpf.Text, Convert.ToInt32(textBMatricula.Text)) && !CampoVazio(textBCpf.Text))
            {
                MessageBox.Show("CPF ja cadastrado!!", "Erro");
                return true;
            }
            return false;
        }
    }
}