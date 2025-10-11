namespace ProjetoAssistenciaTecnica.View
{
    partial class FPessoa
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
            label4 = new Label();
            label5 = new Label();
            txtDataNascimento = new MaskedTextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            tabControl1 = new TabControl();
            TabPage1 = new TabPage();
            panel4 = new Panel();
            comboCargo = new ComboBox();
            maskCPFcnpj = new MaskedTextBox();
            label17 = new Label();
            comboModalidade = new ComboBox();
            label16 = new Label();
            botaoCadastrarCliente = new Button();
            maskedTelefone = new MaskedTextBox();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            comboComplemento = new ComboBox();
            botaoBuscarCEP = new Button();
            maskedCEP = new MaskedTextBox();
            comboUF = new ComboBox();
            label9 = new Label();
            txtMunicipio = new TextBox();
            label10 = new Label();
            txtNumeroCasa = new TextBox();
            txtRua = new TextBox();
            label15 = new Label();
            label11 = new Label();
            label13 = new Label();
            txtBairro = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label14 = new Label();
            botaoPesquisarPessoa = new Button();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(916, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(64, 64, 64);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(954, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(66, 34);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(64, 64, 64);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(17, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(457, 34);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 6;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 8;
            label5.Text = "Data Nascimento:";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.BackColor = Color.FromArgb(64, 64, 64);
            txtDataNascimento.BorderStyle = BorderStyle.FixedSingle;
            txtDataNascimento.ForeColor = Color.White;
            txtDataNascimento.Location = new Point(18, 214);
            txtDataNascimento.Mask = "0000/00/00";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(164, 34);
            txtDataNascimento.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 251);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(18, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(456, 34);
            txtEmail.TabIndex = 5;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(13, 19);
            label12.Name = "label12";
            label12.Size = new Size(288, 32);
            label12.TabIndex = 0;
            label12.Text = "Cadastro de Pessoa";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1141, 616);
            tabControl1.TabIndex = 50;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(36, 36, 36);
            TabPage1.Controls.Add(panel4);
            TabPage1.Controls.Add(panel3);
            TabPage1.Location = new Point(4, 37);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1133, 575);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Dados";
            TabPage1.Click += TabPage1_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(comboCargo);
            panel4.Controls.Add(maskCPFcnpj);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(comboModalidade);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(txtDataNascimento);
            panel4.Controls.Add(botaoCadastrarCliente);
            panel4.Controls.Add(maskedTelefone);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtNome);
            panel4.Controls.Add(txtID);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtEmail);
            panel4.Location = new Point(34, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(1048, 313);
            panel4.TabIndex = 57;
            // 
            // comboCargo
            // 
            comboCargo.BackColor = Color.FromArgb(64, 64, 64);
            comboCargo.ForeColor = Color.White;
            comboCargo.FormattingEnabled = true;
            comboCargo.Items.AddRange(new object[] { "Auxiliar Técnico", "Recepcionista", "Gerente Técnico", "Gerente Administrativo", "Outro" });
            comboCargo.Location = new Point(869, 160);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(151, 36);
            comboCargo.TabIndex = 16;
            // 
            // maskCPFcnpj
            // 
            maskCPFcnpj.BackColor = Color.FromArgb(64, 64, 64);
            maskCPFcnpj.BorderStyle = BorderStyle.FixedSingle;
            maskCPFcnpj.ForeColor = Color.White;
            maskCPFcnpj.Location = new Point(18, 91);
            maskCPFcnpj.Name = "maskCPFcnpj";
            maskCPFcnpj.Size = new Size(260, 34);
            maskCPFcnpj.TabIndex = 3;
            maskCPFcnpj.TextChanged += maskCPFcnpj_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(740, 162);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(69, 28);
            label17.TabIndex = 55;
            label17.Text = "Cargo:";
            // 
            // comboModalidade
            // 
            comboModalidade.BackColor = Color.FromArgb(64, 64, 64);
            comboModalidade.ForeColor = Color.White;
            comboModalidade.FormattingEnabled = true;
            comboModalidade.Items.AddRange(new object[] { "Cliente", "Funcionario" });
            comboModalidade.Location = new Point(869, 97);
            comboModalidade.Name = "comboModalidade";
            comboModalidade.Size = new Size(151, 36);
            comboModalidade.TabIndex = 15;
            comboModalidade.SelectedIndexChanged += comboModalidade_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(740, 100);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(122, 28);
            label16.TabIndex = 52;
            label16.Text = "Modalidade:";
            // 
            // botaoCadastrarCliente
            // 
            botaoCadastrarCliente.BackColor = Color.FromArgb(64, 64, 64);
            botaoCadastrarCliente.FlatStyle = FlatStyle.Popup;
            botaoCadastrarCliente.Font = new Font("Microsoft Sans Serif", 12.2F);
            botaoCadastrarCliente.ForeColor = Color.White;
            botaoCadastrarCliente.Location = new Point(895, 222);
            botaoCadastrarCliente.Name = "botaoCadastrarCliente";
            botaoCadastrarCliente.Size = new Size(125, 38);
            botaoCadastrarCliente.TabIndex = 33;
            botaoCadastrarCliente.Text = "Cadastrar";
            botaoCadastrarCliente.UseVisualStyleBackColor = false;
            botaoCadastrarCliente.Click += botaoCadastrarCliente_Click;
            // 
            // maskedTelefone
            // 
            maskedTelefone.BackColor = Color.FromArgb(64, 64, 64);
            maskedTelefone.BorderStyle = BorderStyle.FixedSingle;
            maskedTelefone.ForeColor = Color.White;
            maskedTelefone.Location = new Point(18, 152);
            maskedTelefone.Mask = "(##) # ####-####";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(260, 34);
            maskedTelefone.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboComplemento);
            panel3.Controls.Add(botaoBuscarCEP);
            panel3.Controls.Add(maskedCEP);
            panel3.Controls.Add(comboUF);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtMunicipio);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtNumeroCasa);
            panel3.Controls.Add(txtRua);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtBairro);
            panel3.Location = new Point(35, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(1047, 227);
            panel3.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(124, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 18);
            label7.TabIndex = 35;
            label7.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(599, 125);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 18);
            label8.TabIndex = 37;
            label8.Text = "UF:";
            // 
            // comboComplemento
            // 
            comboComplemento.BackColor = Color.FromArgb(64, 64, 64);
            comboComplemento.ForeColor = Color.White;
            comboComplemento.FormattingEnabled = true;
            comboComplemento.Items.AddRange(new object[] { "Casa", "Apartamento", "Bloco", "Outro" });
            comboComplemento.Location = new Point(713, 173);
            comboComplemento.Name = "comboComplemento";
            comboComplemento.Size = new Size(151, 36);
            comboComplemento.TabIndex = 12;
            // 
            // botaoBuscarCEP
            // 
            botaoBuscarCEP.BackColor = Color.FromArgb(64, 64, 64);
            botaoBuscarCEP.FlatStyle = FlatStyle.Popup;
            botaoBuscarCEP.Font = new Font("Microsoft Sans Serif", 12.2F);
            botaoBuscarCEP.ForeColor = Color.White;
            botaoBuscarCEP.Location = new Point(467, 22);
            botaoBuscarCEP.Name = "botaoBuscarCEP";
            botaoBuscarCEP.Size = new Size(95, 34);
            botaoBuscarCEP.TabIndex = 7;
            botaoBuscarCEP.Text = "Buscar";
            botaoBuscarCEP.UseVisualStyleBackColor = false;
            botaoBuscarCEP.Click += botaoBuscarCEP_Click;
            // 
            // maskedCEP
            // 
            maskedCEP.BackColor = Color.FromArgb(64, 64, 64);
            maskedCEP.BorderStyle = BorderStyle.FixedSingle;
            maskedCEP.ForeColor = Color.White;
            maskedCEP.Location = new Point(214, 22);
            maskedCEP.Mask = "#####-###";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(234, 34);
            maskedCEP.TabIndex = 6;
            // 
            // comboUF
            // 
            comboUF.BackColor = Color.FromArgb(64, 64, 64);
            comboUF.ForeColor = Color.White;
            comboUF.FormattingEnabled = true;
            comboUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboUF.Location = new Point(713, 115);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(151, 36);
            comboUF.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(124, 185);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 18);
            label9.TabIndex = 42;
            label9.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.BackColor = Color.FromArgb(64, 64, 64);
            txtMunicipio.BorderStyle = BorderStyle.FixedSingle;
            txtMunicipio.ForeColor = Color.White;
            txtMunicipio.Location = new Point(214, 175);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(348, 34);
            txtMunicipio.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(123, 81);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 18);
            label10.TabIndex = 44;
            label10.Text = "Rua:";
            // 
            // txtNumeroCasa
            // 
            txtNumeroCasa.BackColor = Color.FromArgb(64, 64, 64);
            txtNumeroCasa.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroCasa.ForeColor = Color.White;
            txtNumeroCasa.Location = new Point(713, 65);
            txtNumeroCasa.Name = "txtNumeroCasa";
            txtNumeroCasa.Size = new Size(151, 34);
            txtNumeroCasa.TabIndex = 13;
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.FromArgb(64, 64, 64);
            txtRua.BorderStyle = BorderStyle.FixedSingle;
            txtRua.ForeColor = Color.White;
            txtRua.Location = new Point(214, 71);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(348, 34);
            txtRua.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(599, 79);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(28, 18);
            label15.TabIndex = 50;
            label15.Text = "Nº:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(124, 127);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 18);
            label11.TabIndex = 46;
            label11.Text = "Bairro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(599, 177);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(106, 18);
            label13.TabIndex = 48;
            label13.Text = "Complemento:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.FromArgb(64, 64, 64);
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.ForeColor = Color.White;
            txtBairro.Location = new Point(214, 121);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(350, 34);
            txtBairro.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1133, 583);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pesquisa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Column3, Column1, Column4, Column2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1127, 516);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "idPessoa";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 700;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "cpf_cnpj";
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cargo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "telefone";
            Column4.HeaderText = "Telefone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "data_nascimento";
            Column2.HeaderText = "Data Nascimento";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(botaoPesquisarPessoa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1127, 61);
            panel2.TabIndex = 1;
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
            // botaoPesquisarPessoa
            // 
            botaoPesquisarPessoa.Location = new Point(536, 15);
            botaoPesquisarPessoa.Name = "botaoPesquisarPessoa";
            botaoPesquisarPessoa.Size = new Size(144, 36);
            botaoPesquisarPessoa.TabIndex = 1;
            botaoPesquisarPessoa.Text = "Pesquisar";
            botaoPesquisarPessoa.UseVisualStyleBackColor = true;
            botaoPesquisarPessoa.Click += botaoPesquisarPessoa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 71);
            panel1.TabIndex = 49;
            // 
            // FPessoa
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1141, 687);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FPessoa";
            Text = "FPessoa";
            tabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtDataNascimento;
        private Label label6;
        private TextBox txtEmail;
        private Label label12;
        private TabControl tabControl1;
        private TabPage TabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private TextBox textBox1;
        private Label label14;
        private Button botaoPesquisarPessoa;
        private DataGridView dataGridView1;
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
        private Label label13;
        private TextBox txtBairro;
        private Label label11;
        private TextBox txtNumeroCasa;
        private Label label15;
        private ComboBox comboModalidade;
        private Label label16;
        private MaskedTextBox maskedTelefone;
        private ComboBox comboCargo;
        private Label label17;
        private ComboBox comboComplemento;
        private MaskedTextBox maskCPFcnpj;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
    }
}