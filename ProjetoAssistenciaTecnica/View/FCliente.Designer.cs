namespace ProjetoAssistenciaTecnica.View
{
    partial class FCliente
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
            label1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCPF = new TextBox();
            txtDataNascimento = new MaskedTextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            panel1 = new Panel();
            label12 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboModalidade = new ComboBox();
            label16 = new Label();
            txtNumeroCasa = new TextBox();
            label15 = new Label();
            txtComplemento = new TextBox();
            label13 = new Label();
            txtBairro = new TextBox();
            label11 = new Label();
            txtRua = new TextBox();
            label10 = new Label();
            txtMunicipio = new TextBox();
            label9 = new Label();
            comboUF = new ComboBox();
            maskedCEP = new MaskedTextBox();
            botaoBuscarCEP = new Button();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            botaoCadastrarCliente = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label14 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(106, 25);
            txtID.Name = "txtID";
            txtID.Size = new Size(82, 29);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(529, 29);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(106, 147);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(260, 29);
            txtTelefone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 6;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(737, 25);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 8;
            label5.Text = "Data Nascimento:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(106, 107);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(260, 29);
            txtCPF.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(910, 22);
            txtDataNascimento.Mask = "0000/00/00";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(164, 29);
            txtDataNascimento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 187);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(426, 29);
            txtEmail.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 71);
            panel1.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(23, 18);
            label12.Name = "label12";
            label12.Size = new Size(204, 26);
            label12.TabIndex = 0;
            label12.Text = "Cadastro de Cliente";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 596);
            tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(224, 224, 224);
            tabPage1.Controls.Add(comboModalidade);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(txtNumeroCasa);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtComplemento);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtRua);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtMunicipio);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(comboUF);
            tabPage1.Controls.Add(maskedCEP);
            tabPage1.Controls.Add(botaoBuscarCEP);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(botaoCadastrarCliente);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtDataNascimento);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1342, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            // 
            // comboModalidade
            // 
            comboModalidade.FormattingEnabled = true;
            comboModalidade.Items.AddRange(new object[] { "Cliente", "Funcionario" });
            comboModalidade.Location = new Point(909, 64);
            comboModalidade.Name = "comboModalidade";
            comboModalidade.Size = new Size(151, 29);
            comboModalidade.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(780, 67);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(95, 21);
            label16.TabIndex = 52;
            label16.Text = "Modalidade:";
            // 
            // txtNumeroCasa
            // 
            txtNumeroCasa.Location = new Point(106, 497);
            txtNumeroCasa.Name = "txtNumeroCasa";
            txtNumeroCasa.Size = new Size(59, 29);
            txtNumeroCasa.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(57, 503);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(32, 21);
            label15.TabIndex = 50;
            label15.Text = "Nº:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(106, 457);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(426, 29);
            txtComplemento.TabIndex = 49;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(6, 469);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(82, 13);
            label13.TabIndex = 48;
            label13.Text = "Complemento:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(104, 417);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(426, 29);
            txtBairro.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 423);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 46;
            label11.Text = "Bairro:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(104, 377);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(426, 29);
            txtRua.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 383);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 44;
            label10.Text = "Rua:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(104, 326);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(426, 29);
            txtMunicipio.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 332);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 21);
            label9.TabIndex = 42;
            label9.Text = "Municipio:";
            // 
            // comboUF
            // 
            comboUF.FormattingEnabled = true;
            comboUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboUF.Location = new Point(104, 284);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(151, 29);
            comboUF.TabIndex = 41;
            // 
            // maskedCEP
            // 
            maskedCEP.Location = new Point(106, 231);
            maskedCEP.Mask = "#####-###";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(260, 29);
            maskedCEP.TabIndex = 40;
            // 
            // botaoBuscarCEP
            // 
            botaoBuscarCEP.BackColor = Color.FromArgb(64, 64, 64);
            botaoBuscarCEP.FlatStyle = FlatStyle.Popup;
            botaoBuscarCEP.Font = new Font("Microsoft Sans Serif", 12.2F);
            botaoBuscarCEP.ForeColor = Color.White;
            botaoBuscarCEP.Location = new Point(405, 232);
            botaoBuscarCEP.Name = "botaoBuscarCEP";
            botaoBuscarCEP.Size = new Size(125, 34);
            botaoBuscarCEP.TabIndex = 39;
            botaoBuscarCEP.Text = "Buscar";
            botaoBuscarCEP.UseVisualStyleBackColor = false;
            botaoBuscarCEP.Click += botaoBuscarCEP_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 292);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 21);
            label8.TabIndex = 37;
            label8.Text = "UF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 234);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 35;
            label7.Text = "CEP:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12.2F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(909, 155);
            button3.Name = "button3";
            button3.Size = new Size(125, 42);
            button3.TabIndex = 33;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // botaoCadastrarCliente
            // 
            botaoCadastrarCliente.BackColor = Color.FromArgb(64, 64, 64);
            botaoCadastrarCliente.FlatStyle = FlatStyle.Popup;
            botaoCadastrarCliente.Font = new Font("Microsoft Sans Serif", 12.2F);
            botaoCadastrarCliente.ForeColor = Color.White;
            botaoCadastrarCliente.Location = new Point(909, 107);
            botaoCadastrarCliente.Name = "botaoCadastrarCliente";
            botaoCadastrarCliente.Size = new Size(125, 42);
            botaoCadastrarCliente.TabIndex = 33;
            botaoCadastrarCliente.Text = "Cadastrar";
            botaoCadastrarCliente.UseVisualStyleBackColor = false;
            botaoCadastrarCliente.Click += botaoCadastrarCliente_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1342, 568);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pesquisa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1336, 501);
            dataGridView1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1336, 61);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 29);
            textBox1.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 17);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 3;
            label14.Text = "Nome:";
            // 
            // button1
            // 
            button1.Location = new Point(536, 15);
            button1.Name = "button1";
            button1.Size = new Size(144, 36);
            button1.TabIndex = 1;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 667);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FCliente";
            Text = "FPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private Label label5;
        private TextBox txtCPF;
        private MaskedTextBox txtDataNascimento;
        private Label label6;
        private TextBox txtEmail;
        private Panel panel1;
        private Label label12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private TextBox textBox1;
        private Label label14;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private Button button3;
        private Button botaoCadastrarCliente;
        private Label label7;
        private Button botaoBuscarCEP;
        private Label label8;
        private MaskedTextBox maskedCEP;
        private ComboBox comboUF;
        private TextBox txtMunicipio;
        private Label label9;
        private TextBox txtRua;
        private Label label10;
        private TextBox txtComplemento;
        private Label label13;
        private TextBox txtBairro;
        private Label label11;
        private TextBox txtNumeroCasa;
        private Label label15;
        private ComboBox comboModalidade;
        private Label label16;
    }
}