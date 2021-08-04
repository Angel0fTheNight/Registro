
namespace Interface
{
    partial class FormAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            this.groupBCadEditAluno = new System.Windows.Forms.GroupBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBSexo = new System.Windows.Forms.ComboBox();
            this.acessoFBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBCpf = new System.Windows.Forms.TextBox();
            this.textBNome = new System.Windows.Forms.TextBox();
            this.maskedTBNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textBMatricula = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBCadEditAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoFBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBCadEditAluno
            // 
            this.groupBCadEditAluno.Controls.Add(this.buttonAdicionar);
            this.groupBCadEditAluno.Controls.Add(this.buttonLimpar);
            this.groupBCadEditAluno.Controls.Add(this.comboBSexo);
            this.groupBCadEditAluno.Controls.Add(this.textBCpf);
            this.groupBCadEditAluno.Controls.Add(this.textBNome);
            this.groupBCadEditAluno.Controls.Add(this.maskedTBNascimento);
            this.groupBCadEditAluno.Controls.Add(this.textBMatricula);
            this.groupBCadEditAluno.Controls.Add(this.labelCpf);
            this.groupBCadEditAluno.Controls.Add(this.labelNascimento);
            this.groupBCadEditAluno.Controls.Add(this.labelSexo);
            this.groupBCadEditAluno.Controls.Add(this.labelNome);
            this.groupBCadEditAluno.Controls.Add(this.labelMatricula);
            this.groupBCadEditAluno.Location = new System.Drawing.Point(12, 12);
            this.groupBCadEditAluno.Name = "groupBCadEditAluno";
            this.groupBCadEditAluno.Size = new System.Drawing.Size(559, 124);
            this.groupBCadEditAluno.TabIndex = 0;
            this.groupBCadEditAluno.TabStop = false;
            this.groupBCadEditAluno.Text = "Novo aluno";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(462, 88);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 7;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(381, 88);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // comboBSexo
            // 
            this.comboBSexo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.acessoFBBindingSource, "Sexo", true));
            this.comboBSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBSexo.FormattingEnabled = true;
            this.comboBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBSexo.Location = new System.Drawing.Point(19, 90);
            this.comboBSexo.Name = "comboBSexo";
            this.comboBSexo.Size = new System.Drawing.Size(88, 21);
            this.comboBSexo.TabIndex = 3;
            // 
            // acessoFBBindingSource
            // 
            this.acessoFBBindingSource.DataSource = typeof(EM.Repository.AcessoFB);
            // 
            // textBCpf
            // 
            this.textBCpf.Location = new System.Drawing.Point(235, 91);
            this.textBCpf.MaxLength = 11;
            this.textBCpf.Name = "textBCpf";
            this.textBCpf.ShortcutsEnabled = false;
            this.textBCpf.Size = new System.Drawing.Size(130, 20);
            this.textBCpf.TabIndex = 5;
            this.textBCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // textBNome
            // 
            this.textBNome.Location = new System.Drawing.Point(116, 41);
            this.textBNome.MaxLength = 100;
            this.textBNome.Name = "textBNome";
            this.textBNome.ShortcutsEnabled = false;
            this.textBNome.Size = new System.Drawing.Size(421, 20);
            this.textBNome.TabIndex = 2;
            this.textBNome.TextChanged += new System.EventHandler(this.textBNome_TextChanged);
            this.textBNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // maskedTBNascimento
            // 
            this.maskedTBNascimento.Location = new System.Drawing.Point(116, 91);
            this.maskedTBNascimento.Mask = "00/00/0000";
            this.maskedTBNascimento.Name = "maskedTBNascimento";
            this.maskedTBNascimento.ShortcutsEnabled = false;
            this.maskedTBNascimento.Size = new System.Drawing.Size(100, 20);
            this.maskedTBNascimento.TabIndex = 4;
            this.maskedTBNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBMatricula
            // 
            this.textBMatricula.Location = new System.Drawing.Point(19, 41);
            this.textBMatricula.MaxLength = 9;
            this.textBMatricula.Name = "textBMatricula";
            this.textBMatricula.ShortcutsEnabled = false;
            this.textBMatricula.Size = new System.Drawing.Size(91, 20);
            this.textBMatricula.TabIndex = 1;
            this.textBMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            this.textBMatricula.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(232, 74);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "CPF";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(113, 74);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(63, 13);
            this.labelNascimento.TabIndex = 3;
            this.labelNascimento.Text = "Nascimento";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(16, 74);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(113, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(16, 25);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(52, 13);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.Text = "Matrícula";
            // 
            // textBPesquisa
            // 
            this.textBPesquisa.Location = new System.Drawing.Point(12, 145);
            this.textBPesquisa.MaxLength = 100;
            this.textBPesquisa.Name = "textBPesquisa";
            this.textBPesquisa.ShortcutsEnabled = false;
            this.textBPesquisa.Size = new System.Drawing.Size(456, 20);
            this.textBPesquisa.TabIndex = 8;
            this.textBPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(474, 142);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 9;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AllowUserToResizeColumns = false;
            this.dgvAluno.AllowUserToResizeRows = false;
            this.dgvAluno.AutoGenerateColumns = false;
            this.dgvAluno.BackgroundColor = System.Drawing.Color.White;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn});
            this.dgvAluno.DataSource = this.acessoFBBindingSource;
            this.dgvAluno.EnableHeadersVisualStyles = false;
            this.dgvAluno.Location = new System.Drawing.Point(12, 171);
            this.dgvAluno.MultiSelect = false;
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.RowHeadersVisible = false;
            this.dgvAluno.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAluno.Size = new System.Drawing.Size(550, 221);
            this.dgvAluno.StandardTab = true;
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            this.dgvAluno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAluno_CellFormatting);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 75;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.Location = new System.Drawing.Point(93, 398);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 398);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(487, 398);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 428);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBPesquisa);
            this.Controls.Add(this.groupBCadEditAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAluno";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBCadEditAluno.ResumeLayout(false);
            this.groupBCadEditAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoFBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBCadEditAluno;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBSexo;
        private System.Windows.Forms.TextBox textBCpf;
        private System.Windows.Forms.TextBox textBNome;
        private System.Windows.Forms.MaskedTextBox maskedTBNascimento;
        private System.Windows.Forms.TextBox textBMatricula;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox textBPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.BindingSource acessoFBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.DataGridView dgvAluno;
    }
}

