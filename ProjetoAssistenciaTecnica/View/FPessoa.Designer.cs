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
            txtTelefone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCPF = new TextBox();
            botaoSalvar = new Button();
            txtDataNascimento = new MaskedTextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(80, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 34);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(529, 34);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(107, 187);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(426, 34);
            txtTelefone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 258);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 28);
            label5.TabIndex = 8;
            label5.Text = "DT Nascimento";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(80, 124);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 34);
            txtCPF.TabIndex = 4;
            // 
            // botaoSalvar
            // 
            botaoSalvar.Location = new Point(680, 30);
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(268, 244);
            botaoSalvar.TabIndex = 18;
            botaoSalvar.Text = "SALVAR";
            botaoSalvar.UseVisualStyleBackColor = true;
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(177, 258);
            txtDataNascimento.Mask = "0000/00/00";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(184, 34);
            txtDataNascimento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 331);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(426, 34);
            txtEmail.TabIndex = 21;
            // 
            // FPessoa
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 429);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtDataNascimento);
            Controls.Add(botaoSalvar);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FPessoa";
            Text = "FPessoa";
            ResumeLayout(false);
            PerformLayout();
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
        private Button botaoSalvar;
        private MaskedTextBox txtDataNascimento;
        private Label label6;
        private TextBox txtEmail;
    }
}