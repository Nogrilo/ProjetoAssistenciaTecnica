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
            txtCondicao = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            botaoCadastrarProduto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            txtCPFCliente = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtNumeroSerie = new TextBox();
            txtTipo = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            txtCondicao.SuspendLayout();
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
            tabControl1.Controls.Add(txtCondicao);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // txtCondicao
            // 
            txtCondicao.Controls.Add(textBox1);
            txtCondicao.Controls.Add(txtTipo);
            txtCondicao.Controls.Add(txtNumeroSerie);
            txtCondicao.Controls.Add(txtModelo);
            txtCondicao.Controls.Add(txtMarca);
            txtCondicao.Controls.Add(txtCPFCliente);
            txtCondicao.Controls.Add(label7);
            txtCondicao.Controls.Add(label6);
            txtCondicao.Controls.Add(label4);
            txtCondicao.Controls.Add(botaoCadastrarProduto);
            txtCondicao.Controls.Add(label1);
            txtCondicao.Controls.Add(label2);
            txtCondicao.Controls.Add(label3);
            txtCondicao.Location = new Point(4, 24);
            txtCondicao.Name = "txtCondicao";
            txtCondicao.Padding = new Padding(3);
            txtCondicao.Size = new Size(792, 322);
            txtCondicao.TabIndex = 0;
            txtCondicao.Text = "Cadastro";
            txtCondicao.UseVisualStyleBackColor = true;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 156);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "Tipo";
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
            // botaoCadastrarProduto
            // 
            botaoCadastrarProduto.Location = new Point(122, 234);
            botaoCadastrarProduto.Margin = new Padding(3, 2, 3, 2);
            botaoCadastrarProduto.Name = "botaoCadastrarProduto";
            botaoCadastrarProduto.Size = new Size(82, 22);
            botaoCadastrarProduto.TabIndex = 12;
            botaoCadastrarProduto.Text = "Cadastrar";
            botaoCadastrarProduto.UseVisualStyleBackColor = true;
            botaoCadastrarProduto.Click += botaoCadastrarProduto_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Marca";
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
            // txtCPFCliente
            // 
            txtCPFCliente.Location = new Point(122, 14);
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(195, 23);
            txtCPFCliente.TabIndex = 18;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(122, 50);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(195, 23);
            txtMarca.TabIndex = 19;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(122, 83);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(195, 23);
            txtModelo.TabIndex = 20;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(122, 120);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(195, 23);
            txtNumeroSerie.TabIndex = 21;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(122, 156);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(195, 23);
            txtTipo.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 23;
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
            txtCondicao.ResumeLayout(false);
            txtCondicao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TabControl tabControl1;
        private TabPage txtCondicao;
        private TabPage tabPage2;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtCPFCliente;
        private Button botaoCadastrarProduto;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCusto;
        private Label label3;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox textBox1;
        private TextBox txtTipo;
    }
}