namespace ProjetoAssistenciaTecnica.View
{
    partial class FCadastro_de_peças
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNome = new TextBox();
            txtCusto = new TextBox();
            txtCustoRepasse = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            botaoCadastrarPeca = new Button();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            button1 = new Button();
            label10 = new Label();
            label6 = new Label();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            tabPage3 = new TabPage();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label13 = new Label();
            textBox12 = new TextBox();
            textBox15 = new TextBox();
            label16 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBox14 = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "custo material";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 1;
            label3.Text = "valor venda";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(165, 15);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(252, 23);
            txtNome.TabIndex = 3;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(209, 46);
            txtCusto.Margin = new Padding(3, 2, 3, 2);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(252, 23);
            txtCusto.TabIndex = 3;
            // 
            // txtCustoRepasse
            // 
            txtCustoRepasse.Location = new Point(193, 76);
            txtCustoRepasse.Margin = new Padding(3, 2, 3, 2);
            txtCustoRepasse.Name = "txtCustoRepasse";
            txtCustoRepasse.Size = new Size(148, 23);
            txtCustoRepasse.TabIndex = 3;
            // 
            // panel1
            // 
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
            label5.Location = new Point(203, 16);
            label5.Name = "label5";
            label5.Size = new Size(202, 30);
            label5.TabIndex = 0;
            label5.Text = "Cadastro de Peças";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 56);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 333);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 305);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(botaoCadastrarPeca);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCusto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustoRepasse);
            panel2.Location = new Point(40, 19);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 164);
            panel2.TabIndex = 4;
            // 
            // botaoCadastrarPeca
            // 
            botaoCadastrarPeca.Location = new Point(193, 117);
            botaoCadastrarPeca.Margin = new Padding(3, 2, 3, 2);
            botaoCadastrarPeca.Name = "botaoCadastrarPeca";
            botaoCadastrarPeca.Size = new Size(82, 22);
            botaoCadastrarPeca.TabIndex = 5;
            botaoCadastrarPeca.Text = "Cadastrar";
            botaoCadastrarPeca.UseVisualStyleBackColor = true;
            botaoCadastrarPeca.Click += botaoCadastrarPeca_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(692, 305);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pesquisa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox8);
            panel3.Location = new Point(50, 17);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(593, 193);
            panel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(496, 34);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(428, 11);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 0;
            label10.Text = "Codigo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 56);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 0;
            label6.Text = "nome:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(484, 9);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(95, 23);
            textBox9.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(95, 56);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 23);
            textBox5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 87);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 1;
            label7.Text = "custo material";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(139, 87);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(123, 152);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(148, 23);
            textBox7.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 154);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 1;
            label8.Text = "valor venda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 120);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 1;
            label9.Text = "valor venda";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(123, 118);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(148, 23);
            textBox8.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(692, 305);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inclusao";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(textBox11);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(textBox12);
            panel4.Controls.Add(textBox15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(textBox13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox14);
            panel4.Location = new Point(50, 32);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(593, 226);
            panel4.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(496, 78);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 4;
            button4.Text = "Adicionar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(496, 34);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 4;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(428, 11);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 0;
            label11.Text = "Codigo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 62);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 0;
            label12.Text = "nome:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(484, 9);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(95, 23);
            textBox10.TabIndex = 3;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(93, 62);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(252, 23);
            textBox11.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 93);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 1;
            label13.Text = "custo material";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(136, 93);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(252, 23);
            textBox12.TabIndex = 3;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(108, 9);
            textBox15.Margin = new Padding(3, 2, 3, 2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(148, 23);
            textBox15.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(67, 11);
            label16.Name = "label16";
            label16.Size = new Size(26, 15);
            label16.TabIndex = 1;
            label16.Text = "tick";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(121, 158);
            textBox13.Margin = new Padding(3, 2, 3, 2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(148, 23);
            textBox13.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 160);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 1;
            label14.Text = "valor venda";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 126);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 1;
            label15.Text = "valor venda";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(121, 124);
            textBox14.Margin = new Padding(3, 2, 3, 2);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(148, 23);
            textBox14.TabIndex = 3;
            // 
            // FCadastro_de_peças
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 389);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCadastro_de_peças";
            Text = "FCadastro_de_peças";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNome;
        private TextBox txtCusto;
        private TextBox txtCustoRepasse;
        private Panel panel1;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private Button botaoCadastrarPeca;
        private Panel panel3;
        private Button button1;
        private Label label10;
        private Label label6;
        private TextBox textBox9;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label8;
        private TabPage tabPage3;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private Label label11;
        private Label label12;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox12;
        private TextBox textBox15;
        private Label label16;
        private TextBox textBox13;
        private Label label14;
        private Label label15;
        private TextBox textBox14;
    }
}