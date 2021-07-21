
namespace Registro
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdcionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.comboBSexo = new System.Windows.Forms.ComboBox();
            this.textBCpf = new System.Windows.Forms.TextBox();
            this.maskedTBNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textBNome = new System.Windows.Forms.TextBox();
            this.textBMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisae = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdcionar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.comboBSexo);
            this.groupBox1.Controls.Add(this.textBCpf);
            this.groupBox1.Controls.Add(this.maskedTBNascimento);
            this.groupBox1.Controls.Add(this.textBNome);
            this.groupBox1.Controls.Add(this.textBMatricula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo aluno / Editando aluno";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAdcionar
            // 
            this.buttonAdcionar.Location = new System.Drawing.Point(461, 102);
            this.buttonAdcionar.Name = "buttonAdcionar";
            this.buttonAdcionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdcionar.TabIndex = 10;
            this.buttonAdcionar.Text = "Adcionar";
            this.buttonAdcionar.UseVisualStyleBackColor = true;
            this.buttonAdcionar.Click += new System.EventHandler(this.buttonAdcionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(375, 102);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(80, 23);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // comboBSexo
            // 
            this.comboBSexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBSexo.FormattingEnabled = true;
            this.comboBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBSexo.Location = new System.Drawing.Point(26, 101);
            this.comboBSexo.Name = "comboBSexo";
            this.comboBSexo.Size = new System.Drawing.Size(82, 21);
            this.comboBSexo.TabIndex = 9;
            this.comboBSexo.SelectedIndexChanged += new System.EventHandler(this.comboBSexo_SelectedIndexChanged);
            this.comboBSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBSexo_KeyPress);
            // 
            // textBCpf
            // 
            this.textBCpf.Location = new System.Drawing.Point(243, 102);
            this.textBCpf.MaxLength = 11;
            this.textBCpf.Name = "textBCpf";
            this.textBCpf.Size = new System.Drawing.Size(126, 20);
            this.textBCpf.TabIndex = 8;
            this.textBCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBCpf_KeyPress);
            this.textBCpf.Leave += new System.EventHandler(this.textBCpf_Leave);
            // 
            // maskedTBNascimento
            // 
            this.maskedTBNascimento.Location = new System.Drawing.Point(121, 101);
            this.maskedTBNascimento.Mask = "00/00/0000";
            this.maskedTBNascimento.Name = "maskedTBNascimento";
            this.maskedTBNascimento.Size = new System.Drawing.Size(107, 20);
            this.maskedTBNascimento.TabIndex = 7;
            this.maskedTBNascimento.ValidatingType = typeof(System.DateTime);
            this.maskedTBNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTBNascimento_MaskInputRejected);
            // 
            // textBNome
            // 
            this.textBNome.Location = new System.Drawing.Point(121, 41);
            this.textBNome.MaxLength = 100;
            this.textBNome.Name = "textBNome";
            this.textBNome.Size = new System.Drawing.Size(420, 20);
            this.textBNome.TabIndex = 6;
            this.textBNome.TextChanged += new System.EventHandler(this.textBNome_TextChanged);
            // 
            // textBMatricula
            // 
            this.textBMatricula.Location = new System.Drawing.Point(19, 41);
            this.textBMatricula.MaxLength = 9;
            this.textBMatricula.Name = "textBMatricula";
            this.textBMatricula.Size = new System.Drawing.Size(89, 20);
            this.textBMatricula.TabIndex = 5;
            this.textBMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBMatricula.TextChanged += new System.EventHandler(this.textBMatricula_TextChanged);
            this.textBMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBMatricula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // textBPesquisa
            // 
            this.textBPesquisa.Location = new System.Drawing.Point(12, 167);
            this.textBPesquisa.Name = "textBPesquisa";
            this.textBPesquisa.Size = new System.Drawing.Size(455, 20);
            this.textBPesquisa.TabIndex = 1;
            // 
            // buttonPesquisae
            // 
            this.buttonPesquisae.Location = new System.Drawing.Point(473, 165);
            this.buttonPesquisae.Name = "buttonPesquisae";
            this.buttonPesquisae.Size = new System.Drawing.Size(80, 23);
            this.buttonPesquisae.TabIndex = 11;
            this.buttonPesquisae.Text = "Pesquisar";
            this.buttonPesquisae.UseVisualStyleBackColor = true;
            this.buttonPesquisae.Click += new System.EventHandler(this.buttonPesquisae_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(392, 298);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(473, 298);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 13;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.Sexo,
            this.Nascimento,
            this.Cpf});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 43);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Nascimento
            // 
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonPesquisae);
            this.Controls.Add(this.textBPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdcionar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox textBCpf;
        private System.Windows.Forms.MaskedTextBox maskedTBNascimento;
        private System.Windows.Forms.TextBox textBNome;
        private System.Windows.Forms.TextBox textBMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBPesquisa;
        private System.Windows.Forms.Button buttonPesquisae;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.ComboBox comboBSexo;
    }
}

