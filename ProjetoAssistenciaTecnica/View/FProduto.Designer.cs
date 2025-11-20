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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            botaoCadastrarPeca = new Button();
            label1 = new Label();
            this.txtCPFCliente = new TextBox();
            label2 = new Label();
            this.txtMarca = new TextBox();
            label3 = new Label();
            txtModelo = new TextBox();
            label4 = new Label();
            this.txtNSerie = new TextBox();
            label6 = new Label();
            this.txtTipo = new TextBox();
            label7 = new Label();
            this.txtCondicao = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(299, 35);
            label5.Name = "label5";
            label5.Size = new Size(229, 30);
            label5.TabIndex = 1;
            label5.Text = "Cadastro de Produto";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(this.txtCondicao);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(this.txtTipo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(this.txtNSerie);
            tabPage1.Controls.Add(botaoCadastrarPeca);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(this.txtCPFCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(this.txtMarca);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtModelo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // botaoCadastrarPeca
            // 
            botaoCadastrarPeca.Location = new Point(122, 234);
            botaoCadastrarPeca.Margin = new Padding(3, 2, 3, 2);
            botaoCadastrarPeca.Name = "botaoCadastrarPeca";
            botaoCadastrarPeca.Size = new Size(82, 22);
            botaoCadastrarPeca.TabIndex = 12;
            botaoCadastrarPeca.Text = "Cadastrar";
            botaoCadastrarPeca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 6;
            label1.Text = "CPF Cliente";
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Location = new Point(122, 19);
            this.txtCPFCliente.Margin = new Padding(3, 2, 3, 2);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new Size(252, 23);
            this.txtCPFCliente.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new Point(122, 50);
            this.txtMarca.Margin = new Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new Size(252, 23);
            this.txtMarca.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 83);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(122, 80);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(252, 23);
            txtModelo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 120);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Nº Serie";
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new Point(122, 117);
            this.txtNSerie.Margin = new Padding(3, 2, 3, 2);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new Size(252, 23);
            this.txtNSerie.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 156);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new Point(122, 153);
            this.txtTipo.Margin = new Padding(3, 2, 3, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new Size(252, 23);
            this.txtTipo.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 195);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 17;
            label7.Text = "Condicao";
            // 
            // txtCondicao
            // 
            this.txtCondicao.Location = new Point(122, 192);
            this.txtCondicao.Margin = new Padding(3, 2, 3, 2);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.Size = new Size(252, 23);
            this.txtCondicao.TabIndex = 18;
            // 
            // FProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "FProduto";
            Text = "FProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Button botaoCadastrarPeca;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCusto;
        private Label label3;
        private TextBox txtModelo;
    }
}