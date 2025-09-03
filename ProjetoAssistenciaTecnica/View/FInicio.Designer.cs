namespace ProjetoAssistenciaTecnica
{
    partial class FInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            toolStrip1 = new ToolStrip();
            botaoCadastrarCliente = new ToolStripButton();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            botaoCadastrarPessoa = new ToolStripButton();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoCadastrarCliente, botaoCadastrarPessoa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1029, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoCadastrarCliente
            // 
            botaoCadastrarCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoCadastrarCliente.Image = (Image)resources.GetObject("botaoCadastrarCliente.Image");
            botaoCadastrarCliente.ImageTransparentColor = Color.Magenta;
            botaoCadastrarCliente.Name = "botaoCadastrarCliente";
            botaoCadastrarCliente.Size = new Size(29, 24);
            botaoCadastrarCliente.Text = "toolStripButton1";
            botaoCadastrarCliente.ToolTipText = "Cadastrar Cliente";
            botaoCadastrarCliente.Click += botaoCadastrarCliente_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 508);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1029, 508);
            tabControl1.TabIndex = 0;
            // 
            // botaoCadastrarPessoa
            // 
            botaoCadastrarPessoa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoCadastrarPessoa.Image = (Image)resources.GetObject("botaoCadastrarPessoa.Image");
            botaoCadastrarPessoa.ImageTransparentColor = Color.Magenta;
            botaoCadastrarPessoa.Name = "botaoCadastrarPessoa";
            botaoCadastrarPessoa.Size = new Size(29, 24);
            botaoCadastrarPessoa.Text = "toolStripButton1";
            botaoCadastrarPessoa.Click += botaoCadastrarPessoa_Click;
            // 
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 535);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton botaoCadastrarCliente;
        private Panel panel1;
        private TabControl tabControl1;
        private ToolStripButton botaoCadastrarPessoa;
    }
}
