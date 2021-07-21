using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;

namespace Interface
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            preencheGrid();
        }
        private void preencheGrid()
        {
            try
            {
                RepositorioAluno dadosAlunos = new RepositorioAluno();
                bs.DataSource = dadosAlunos.BusqueTodosOsAlunos();
                dataGridAluno.DataSource = bs;
                dataGridAluno.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        private void preencheDados(Aluno alun)
        {
            textBMatricula.Text = alun.Matricula.ToString();
            textBNome.Text = alun.Nome;
            textBCpf.Text = alun.Cpf;
            maskedTBNascimento.Text = Convert.ToString(alun.Nascimento);
            comboBSexo.SelectedIndex = (int)alun.Sexo;
        }
        BindingSource bs = new BindingSource();
        public void limpar()
        {
            textBCpf.Text = string.Empty;
            textBMatricula.Text = string.Empty;
            textBNome.Text = string.Empty;
            maskedTBNascimento.Text = string.Empty;
            comboBSexo.SelectedIndex = -1;
            textBPesquisa.Text = string.Empty;
        }
        public Form1()
        {
            InitializeComponent();
            textBNome.MaxLength = 100;
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            ValidacaoDeCampos validacao = new ValidacaoDeCampos();
            RepositorioAluno dadosaluno = new RepositorioAluno();
            if (validacao.CampoVazio(textBNome.Text.Trim()))
            {
                MessageBox.Show("O campo Nome esta vazio! O campo Nome é um campo obrigatorio!", "Erro");
                textBNome.Clear();
                return;
            }

            if (!ValidarCpf.IsCpf(textBCpf.Text) && textBCpf.Text != string.Empty)
            {
                MessageBox.Show("CPF invalido", "Erro");
                return;
            }
            try
            {
                if (dadosaluno.CpfExistente(textBCpf.Text, Convert.ToInt32(textBMatricula.Text)) && textBCpf.Text != string.Empty)
                {
                    MessageBox.Show("CPF ja cadastrado!!", "Erro");
                    return;
                }
            }
            catch
            {
                if (validacao.CampoVazio(textBMatricula.Text))
                {
                    MessageBox.Show("O campo Matricula esta vazio! O campo Matricula é um campo obrigatorio!", "Erro");
                    return;
                }                               
            }            
            if (validacao.CampoVazio(maskedTBNascimento.Text) || !maskedTBNascimento.MaskCompleted)
            {
                MessageBox.Show("O campo Nascimento esta vazio ou incompleto! O campo Nascimento é um campo obrigatorio!", "Erro");
                return;
            }

            if (comboBSexo.SelectedIndex != 0 && comboBSexo.SelectedIndex != 1)
            {
                MessageBox.Show("O campo Sexo não foi selecionado! O campo Sexo é um campo obrigatorio!", "Erro");
                return;
            }
            DateTime dataValida;
            DateTime dataHoje = DateTime.Today;
            if (!DateTime.TryParse(maskedTBNascimento.Text, out dataValida) || dataHoje <= Convert.ToDateTime(maskedTBNascimento.Text))
            {
                MessageBox.Show("Data Invalida", "Erro");
                return;
            }
            
            Aluno aluno = new Aluno();
            if (buttonAdicionar.Text != "Modificar")
            {              
                aluno.Matricula = Convert.ToInt32(textBMatricula.Text);
                aluno.Nome = textBNome.Text.Trim();
                aluno.Cpf = textBCpf.Text;
                aluno.Nascimento = Convert.ToDateTime(maskedTBNascimento.Text);
                aluno.Sexo = (EnumeradorSexo)comboBSexo.SelectedIndex;
                if (aluno.Matricula == 0 || textBMatricula.Text.Contains("-"))
                {
                    MessageBox.Show("Número de matricula invalido!\nA matricula deve ser positiva e diferente de 0", "Erro");
                    return;
                }
                if (dadosaluno.MatriculaExistente(Convert.ToInt32(textBMatricula.Text)))
                {
                    MessageBox.Show("Número de matricula ja cadastrado!", "Erro");
                    return;
                }
                try
                {
                    dadosaluno.Add(aluno);
                    preencheGrid();
                    MessageBox.Show("Aluno inserido com sucesso !", "Sucesso", MessageBoxButtons.OK);
                    limpar();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro no cadastro, algum dos campos esta inserido de maneira incorreta!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                Aluno alun = new Aluno();
                alun.Matricula = Convert.ToInt32(textBMatricula.Text);
                alun.Nome = textBNome.Text.Trim();
                alun.Cpf = textBCpf.Text;
                alun.Nascimento = Convert.ToDateTime(maskedTBNascimento.Text);
                alun.Sexo = (EnumeradorSexo)comboBSexo.SelectedIndex;

                try
                {
                    dadosaluno.AtualizeOsAlunos(alun);
                    preencheGrid();
                    MessageBox.Show("Aluno modificado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    limpar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro no cadastro, algum dos campos esta inserido de maneira incorreta!", "Erro", MessageBoxButtons.OK);
                }
                buttonAdicionar.Text = "Adicionar";
                buttonLimpar.Text = "Limpar";
                groupBCadEditAluno.Text = "Novo aluno";
                textBMatricula.Enabled = true;
                buttonExcluir.Enabled = false;
            }
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();

            if (buttonLimpar.Text == "Cancelar")
            {
                MessageBox.Show("A edição do aluno foi cancelada");
                buttonAdicionar.Text = "Adicionar";
                buttonLimpar.Text = "Limpar";
                groupBCadEditAluno.Text = "Novo aluno";
                buttonExcluir.Enabled = false;
                textBMatricula.Enabled = true;
            }            
        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            RepositorioAluno repositorioAluno = new RepositorioAluno();
            string resultado = textBPesquisa.Text;

            if (int.TryParse(resultado, out int matricula))
            {                
                try
                {
                    bs.DataSource = repositorioAluno.BusqueAlunosPorMatricula(matricula);
                    dataGridAluno.DataSource = bs;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na consulta!", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                var nomeAluno = textBPesquisa.Text;
                var alunos = (List<Aluno>)repositorioAluno.BusqueAlunosPorParteDoNome(nomeAluno);
                try
                {
                    bs.DataSource = alunos;
                    dataGridAluno.DataSource = bs;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na consulta!", "Erro", MessageBoxButtons.OK);
                }
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Text = "Modificar";
            buttonLimpar.Text = "Cancelar";
            groupBCadEditAluno.Text = "Editando aluno";
            buttonExcluir.Enabled = true;
            textBMatricula.Enabled = false;
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioAluno dadosAlunos = new RepositorioAluno();
                Aluno aluno = dadosAlunos.BusqueAlunosPorMatricula(Convert.ToInt32(textBMatricula.Text));
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Excluir aluno", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        dadosAlunos.RemovaOsAlunos(aluno);
                        preencheGrid();
                        MessageBox.Show("Aluno excluído com sucesso !", "Alterar", MessageBoxButtons.OK);
                        limpar();
                        buttonAdicionar.Text = "Adicionar";
                        buttonLimpar.Text = "Limpar";
                        groupBCadEditAluno.Text = "Novo aluno";
                        buttonExcluir.Enabled = false;
                        textBMatricula.Enabled = true;
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
        private void textBMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 08);
        }

        private void textBCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 08);
        }        
        private void dataGridAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioAluno dadosAlunos = new RepositorioAluno();
            if (e.RowIndex == -1)
            {
                return;               
            }
            else
            {
                if (buttonAdicionar.Text == "Modificar")
                {
                    Aluno aluno = new Aluno();
                    try
                    {
                        int codigo = Convert.ToInt32(dataGridAluno.Rows[e.RowIndex].Cells[0].Value);
                        aluno = dadosAlunos.BusqueAlunosPorMatricula(codigo);
                        textBMatricula.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                    preencheDados(aluno);
                }
            }
        }
        private void textBNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }      
        private void textBPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (textBPesquisa.Text == "")
            {
                preencheGrid();
                textBMatricula.Enabled = true;
            }
        }

        private void dataGridAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {          
            int numeroColunaCPF = 4;
            if (e.ColumnIndex == numeroColunaCPF && e.Value != string.Empty)
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
    }
}
