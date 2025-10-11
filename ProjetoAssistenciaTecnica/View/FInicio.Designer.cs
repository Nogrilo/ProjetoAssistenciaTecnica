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
            botaoCadastrarFuncionario = new ToolStripButton();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripMargin = new Padding(10, 5, 10, 5);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoCadastrarCliente, botaoCadastrarFuncionario, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(45, 535);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoCadastrarCliente
            // 
            botaoCadastrarCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoCadastrarCliente.Image = (Image)resources.GetObject("botaoCadastrarCliente.Image");
            botaoCadastrarCliente.ImageTransparentColor = Color.Magenta;
            botaoCadastrarCliente.Name = "botaoCadastrarCliente";
            botaoCadastrarCliente.Size = new Size(42, 44);
            botaoCadastrarCliente.Text = "Clientes";
            botaoCadastrarCliente.ToolTipText = "Cadastrar Cliente";
            botaoCadastrarCliente.Click += botaoCadastrarCliente_Click;
            // 
            // botaoCadastrarFuncionario
            // 
            botaoCadastrarFuncionario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoCadastrarFuncionario.Image = (Image)resources.GetObject("botaoCadastrarFuncionario.Image");
            botaoCadastrarFuncionario.ImageTransparentColor = Color.Magenta;
            botaoCadastrarFuncionario.Name = "botaoCadastrarFuncionario";
            botaoCadastrarFuncionario.Size = new Size(42, 44);
            botaoCadastrarFuncionario.Text = "Funcionarios";
            botaoCadastrarFuncionario.Click += botaoCadastrarFuncionario_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(45, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 535);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 535);
            tabControl1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(42, 44);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1029, 535);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton = true;
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
        private ToolStripButton botaoCadastrarFuncionario;
        private ToolStripButton toolStripButton1;
    }
}
