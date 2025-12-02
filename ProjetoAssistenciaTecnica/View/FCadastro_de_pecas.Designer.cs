namespace ProjetoAssistenciaTecnica.View
{
    partial class FCadastro_de_pecas
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            label5 = new Label();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            txtCustoRepasse = new TextBox();
            label3 = new Label();
            txtCusto = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            botaoCadastrarPeca = new Button();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 56);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(203, 16);
            label5.Name = "label5";
            label5.Size = new Size(202, 30);
            label5.TabIndex = 0;
            label5.Text = "Cadastro de Peças";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(36, 36, 36);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 305);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(botaoCadastrarPeca);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCusto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustoRepasse);
            panel2.Location = new Point(150, 21);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 251);
            panel2.TabIndex = 4;
            // 
            // txtCustoRepasse
            // 
            txtCustoRepasse.BackColor = Color.FromArgb(64, 64, 64);
            txtCustoRepasse.BorderStyle = BorderStyle.FixedSingle;
            txtCustoRepasse.ForeColor = Color.White;
            txtCustoRepasse.Location = new Point(19, 150);
            txtCustoRepasse.Margin = new Padding(3, 2, 3, 2);
            txtCustoRepasse.Name = "txtCustoRepasse";
            txtCustoRepasse.Size = new Size(148, 23);
            txtCustoRepasse.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 128);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 1;
            label3.Text = "Valor Venda:";
            // 
            // txtCusto
            // 
            txtCusto.BackColor = Color.FromArgb(64, 64, 64);
            txtCusto.BorderStyle = BorderStyle.FixedSingle;
            txtCusto.ForeColor = Color.White;
            txtCusto.Location = new Point(19, 93);
            txtCusto.Margin = new Padding(3, 2, 3, 2);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(148, 23);
            txtCusto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Custo Material:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(64, 64, 64);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(19, 36);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // botaoCadastrarPeca
            // 
            botaoCadastrarPeca.Location = new Point(19, 183);
            botaoCadastrarPeca.Margin = new Padding(3, 2, 3, 2);
            botaoCadastrarPeca.Name = "botaoCadastrarPeca";
            botaoCadastrarPeca.Size = new Size(94, 27);
            botaoCadastrarPeca.TabIndex = 4;
            botaoCadastrarPeca.Text = "Cadastrar";
            botaoCadastrarPeca.UseVisualStyleBackColor = true;
            botaoCadastrarPeca.Click += botaoCadastrarPeca_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 56);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 333);
            tabControl1.TabIndex = 5;
            // 
            // FCadastro_de_pecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(700, 389);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCadastro_de_pecas";
            Text = "FCadastro_de_peças";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label label5;
        private TabPage tabPage1;
        private Panel panel2;
        private Button botaoCadastrarPeca;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCusto;
        private Label label3;
        private TextBox txtCustoRepasse;
        private TabControl tabControl1;
    }
}