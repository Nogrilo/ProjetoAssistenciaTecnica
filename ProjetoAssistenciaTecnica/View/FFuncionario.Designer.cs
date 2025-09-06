namespace ProjetoAssistenciaTecnica.View
{
    partial class FFuncionario
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
            panel1 = new Panel();
            label12 = new Label();
            tabPage1 = new TabPage();
            label1 = new Label();
            txtID = new TextBox();
            txtEmailFuncionario = new TextBox();
            txtPorcentagem = new TextBox();
            txtAtivo = new TextBox();
            txtIDPessoa = new TextBox();
            txtCodigoFuncionario = new TextBox();
            txtNomeFuncionario = new TextBox();
            txtCPFFuncionario = new TextBox();
            txtTelefoneFuncionario = new TextBox();
            label6 = new Label();
            label8 = new Label();
            botaoSalvar = new Button();
            txtDataAdmissao = new MaskedTextBox();
            label9 = new Label();
            comboTipo = new ComboBox();
            label10 = new Label();
            label7 = new Label();
            txtDataNascimentoFuncionario = new MaskedTextBox();
            label2 = new Label();
            label5 = new Label();
            label11 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 71);
            panel1.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Geometr415 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(23, 18);
            label12.Name = "label12";
            label12.Size = new Size(330, 34);
            label12.TabIndex = 0;
            label12.Text = "Cadastro de Funcionarios";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(224, 224, 224);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(txtEmailFuncionario);
            tabPage1.Controls.Add(txtPorcentagem);
            tabPage1.Controls.Add(txtAtivo);
            tabPage1.Controls.Add(txtIDPessoa);
            tabPage1.Controls.Add(txtCodigoFuncionario);
            tabPage1.Controls.Add(txtNomeFuncionario);
            tabPage1.Controls.Add(txtCPFFuncionario);
            tabPage1.Controls.Add(txtTelefoneFuncionario);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(botaoSalvar);
            tabPage1.Controls.Add(txtDataAdmissao);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(comboTipo);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtDataNascimentoFuncionario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1205, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 22;
            label1.Text = "ID Pessoa:";
            // 
            // txtID
            // 
            txtID.Location = new Point(124, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(74, 34);
            txtID.TabIndex = 23;
            // 
            // txtEmailFuncionario
            // 
            txtEmailFuncionario.Location = new Point(126, 185);
            txtEmailFuncionario.Name = "txtEmailFuncionario";
            txtEmailFuncionario.Size = new Size(426, 34);
            txtEmailFuncionario.TabIndex = 34;
            // 
            // txtPorcentagem
            // 
            txtPorcentagem.Location = new Point(827, 189);
            txtPorcentagem.Name = "txtPorcentagem";
            txtPorcentagem.Size = new Size(125, 34);
            txtPorcentagem.TabIndex = 38;
            // 
            // txtAtivo
            // 
            txtAtivo.Location = new Point(897, 19);
            txtAtivo.Name = "txtAtivo";
            txtAtivo.Size = new Size(106, 34);
            txtAtivo.TabIndex = 46;
            // 
            // txtIDPessoa
            // 
            txtIDPessoa.Location = new Point(827, 19);
            txtIDPessoa.Name = "txtIDPessoa";
            txtIDPessoa.Size = new Size(64, 34);
            txtIDPessoa.TabIndex = 43;
            // 
            // txtCodigoFuncionario
            // 
            txtCodigoFuncionario.Location = new Point(827, 107);
            txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            txtCodigoFuncionario.Size = new Size(125, 34);
            txtCodigoFuncionario.TabIndex = 36;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(124, 59);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(428, 34);
            txtNomeFuncionario.TabIndex = 25;
            // 
            // txtCPFFuncionario
            // 
            txtCPFFuncionario.Location = new Point(124, 100);
            txtCPFFuncionario.Name = "txtCPFFuncionario";
            txtCPFFuncionario.Size = new Size(428, 34);
            txtCPFFuncionario.TabIndex = 26;
            // 
            // txtTelefoneFuncionario
            // 
            txtTelefoneFuncionario.Location = new Point(126, 142);
            txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            txtTelefoneFuncionario.Size = new Size(184, 34);
            txtTelefoneFuncionario.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 185);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 33;
            label6.Text = "Email:";
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.WhiteSpace;
            label8.AutoSize = true;
            label8.Location = new Point(692, 189);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 39;
            label8.Text = "Comissão(%):";
            // 
            // botaoSalvar
            // 
            botaoSalvar.BackColor = Color.FromArgb(64, 64, 64);
            botaoSalvar.FlatStyle = FlatStyle.Popup;
            botaoSalvar.Font = new Font("Geometr415 Blk BT", 12.2F);
            botaoSalvar.ForeColor = Color.White;
            botaoSalvar.Location = new Point(827, 239);
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(125, 42);
            botaoSalvar.TabIndex = 32;
            botaoSalvar.Text = "Cadastrar";
            botaoSalvar.UseVisualStyleBackColor = false;
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // txtDataAdmissao
            // 
            txtDataAdmissao.Location = new Point(827, 147);
            txtDataAdmissao.Mask = "0000/00/00";
            txtDataAdmissao.Name = "txtDataAdmissao";
            txtDataAdmissao.Size = new Size(184, 34);
            txtDataAdmissao.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(673, 148);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(147, 28);
            label9.TabIndex = 41;
            label9.Text = "Data Admissao:";
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "Auxiliar Técnico", "Recepcionista", "Gerente Técnico", "Gerente Administrativo", "Outro" });
            comboTipo.Location = new Point(827, 62);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(151, 36);
            comboTipo.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(677, 22);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(143, 28);
            label10.TabIndex = 42;
            label10.Text = "ID Funcionario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(739, 103);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 37;
            label7.Text = "Codigo:";
            // 
            // txtDataNascimentoFuncionario
            // 
            txtDataNascimentoFuncionario.Location = new Point(205, 225);
            txtDataNascimentoFuncionario.Mask = "0000/00/00";
            txtDataNascimentoFuncionario.Name = "txtDataNascimentoFuncionario";
            txtDataNascimentoFuncionario.Size = new Size(105, 34);
            txtDataNascimentoFuncionario.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 24;
            label2.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 225);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 31;
            label5.Text = "Data Nascimento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(765, 62);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 28);
            label11.TabIndex = 45;
            label11.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 27;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 30;
            label4.Text = "Telefone:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1213, 361);
            tabControl1.TabIndex = 49;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1205, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pesquisa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 61);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 34);
            textBox1.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 17);
            label14.Name = "label14";
            label14.Size = new Size(70, 28);
            label14.TabIndex = 3;
            label14.Text = "Nome:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(515, 17);
            label13.Name = "label13";
            label13.Size = new Size(69, 28);
            label13.TabIndex = 2;
            label13.Text = "Cargo:";
            // 
            // button1
            // 
            button1.Location = new Point(833, 14);
            button1.Name = "button1";
            button1.Size = new Size(144, 36);
            button1.TabIndex = 1;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(590, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 36);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Cargo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1199, 253);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 700;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 200;
            // 
            // FFuncionario
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 432);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FFuncionario";
            Text = "Cadastro de Funcionario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label12;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txtID;
        private TextBox txtEmailFuncionario;
        private TextBox txtPorcentagem;
        private TextBox txtAtivo;
        private TextBox txtIDPessoa;
        private TextBox txtCodigoFuncionario;
        private TextBox txtNomeFuncionario;
        private TextBox txtCPFFuncionario;
        private TextBox txtTelefoneFuncionario;
        private Label label6;
        private Label label8;
        private Button botaoSalvar;
        private MaskedTextBox txtDataAdmissao;
        private Label label9;
        private ComboBox comboTipo;
        private Label label10;
        private Label label7;
        private MaskedTextBox txtDataNascimentoFuncionario;
        private Label label2;
        private Label label5;
        private Label label11;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Panel panel2;
        private Label label13;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label14;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cargo;
    }
}