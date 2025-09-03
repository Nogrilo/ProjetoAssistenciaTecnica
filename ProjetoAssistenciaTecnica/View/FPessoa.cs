using ProjetoAssistenciaTecnica.Model;
using ProjetoAssistenciaTecnica.Controller; /* Importar a pasta de controller*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAssistenciaTecnica.View
{
    public partial class FPessoa : Form
    {
        public FPessoa()
        {
            InitializeComponent();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {

            Pessoa obj          = new Pessoa();
            obj.nome            = txtNome.Text;
            obj.cpf_cnpj        = txtCPF.Text;
            obj.telefone        = txtTelefone.Text;
            obj.data_nascimento = txtDataNascimento.Text;

            ControllerPessoa controllerPessoa = new ControllerPessoa();

            controllerPessoa.cadastrarPessoa(obj);
            MessageBox.Show("Ve ai bem certinho");

        }
    }
}
