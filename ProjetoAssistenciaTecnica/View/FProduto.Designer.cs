namespace ProjetoAssistenciaTecnica.View
{
    partial class FProduto
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
            label5 = new Label();
            label100 = new TabPage();
            panel2 = new Panel();
            label1 = new Label();
            txtCondicao = new TextBox();
            label3 = new Label();
            txtTipo = new TextBox();
            label2 = new Label();
            txtNumeroSerie = new TextBox();
            botaoCadastrarProduto = new Button();
            txtModelo = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label6 = new Label();
            txtCPFCliente = new TextBox();
            label7 = new Label();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            label100.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 110);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 28);
            label5.Name = "label5";
            label5.Size = new Size(309, 41);
            label5.TabIndex = 1;
            label5.Text = "Cadastro de Produto";
            // 
            // label100
            // 
            label100.BackColor = Color.FromArgb(36, 36, 36);
            label100.Controls.Add(panel2);
            label100.Location = new Point(4, 29);
            label100.Margin = new Padding(3, 4, 3, 4);
            label100.Name = "label100";
            label100.Padding = new Padding(3, 4, 3, 4);
            label100.Size = new Size(1164, 606);
            label100.TabIndex = 0;
            label100.Text = "Cadastro";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCondicao);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTipo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNumeroSerie);
            panel2.Controls.Add(botaoCadastrarProduto);
            panel2.Controls.Add(txtModelo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCPFCliente);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(277, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 493);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 6;
            label1.Text = "CPF Cliente:";
            // 
            // txtCondicao
            // 
            txtCondicao.BackColor = Color.FromArgb(64, 64, 64);
            txtCondicao.BorderStyle = BorderStyle.FixedSingle;
            txtCondicao.ForeColor = Color.White;
            txtCondicao.Location = new Point(88, 339);
            txtCondicao.Margin = new Padding(3, 4, 3, 4);
            txtCondicao.Multiline = true;
            txtCondicao.Name = "txtCondicao";
            txtCondicao.Size = new Size(414, 71);
            txtCondicao.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 114);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Modelo:";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(64, 64, 64);
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.ForeColor = Color.White;
            txtTipo.Location = new Point(322, 247);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(180, 27);
            txtTipo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 113);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Marca:";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.BackColor = Color.FromArgb(64, 64, 64);
            txtNumeroSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSerie.ForeColor = Color.White;
            txtNumeroSerie.Location = new Point(87, 247);
            txtNumeroSerie.Margin = new Padding(3, 4, 3, 4);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(181, 27);
            txtNumeroSerie.TabIndex = 4;
            // 
            // botaoCadastrarProduto
            // 
            botaoCadastrarProduto.Location = new Point(390, 431);
            botaoCadastrarProduto.Name = "botaoCadastrarProduto";
            botaoCadastrarProduto.Size = new Size(112, 39);
            botaoCadastrarProduto.TabIndex = 7;
            botaoCadastrarProduto.Text = "Cadastrar";
            botaoCadastrarProduto.UseVisualStyleBackColor = true;
            botaoCadastrarProduto.Click += botaoCadastrarProduto_Click;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(64, 64, 64);
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.ForeColor = Color.White;
            txtModelo.Location = new Point(322, 147);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(180, 27);
            txtModelo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(88, 204);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 13;
            label4.Text = "Nº Série:";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(64, 64, 64);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.ForeColor = Color.White;
            txtMarca.Location = new Point(88, 147);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(180, 27);
            txtMarca.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(324, 204);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 15;
            label6.Text = "Tipo:";
            // 
            // txtCPFCliente
            // 
            txtCPFCliente.BackColor = Color.FromArgb(64, 64, 64);
            txtCPFCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCPFCliente.ForeColor = Color.White;
            txtCPFCliente.Location = new Point(88, 63);
            txtCPFCliente.Margin = new Padding(3, 4, 3, 4);
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(278, 27);
            txtCPFCliente.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(87, 305);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 17;
            label7.Text = "Condição:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(label100);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 110);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1172, 639);
            tabControl1.TabIndex = 1;
            // 
            // FProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1172, 749);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FProduto";
            Text = "FProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            label100.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtNome;
        private TextBox txtCusto;
        private TabPage label100;
        private TextBox txtCondicao;
        private TextBox txtTipo;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtCPFCliente;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button botaoCadastrarProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private Panel panel2;
    }
}