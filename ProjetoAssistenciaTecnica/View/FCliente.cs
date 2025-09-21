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
using ViaCep; // Biblioteca do VIA CEP

namespace ProjetoAssistenciaTecnica.View
{
    public partial class FCliente : Form
    {
        public FCliente()
        {
            InitializeComponent();
            habilitarCampos();
        }

        /* Funcao para habilitar os campos, EXCETO o ID */
        public void habilitarCampos()
        {
            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtTelefone.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtEmail.Enabled = true;
        }

        /* Funcao para limpar os campos */
        public void limparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtDataNascimento.Clear();
            txtEmail.Clear();
        }

        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtNome.Text;
            obj.cpf_cnpj = txtCPF.Text;
            obj.telefone = txtTelefone.Text;
            obj.data_nascimento = txtDataNascimento.Text;
            obj.email = txtEmail.Text;

            ControllerCliente controllerPessoa = new ControllerCliente();

            controllerPessoa.cadastrarCliente(obj);
            MessageBox.Show("Pessoa Cadastrada com Sucesso!");
            limparCampos();
        }

        private void botaoBuscarCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text;   
            
            var resultado       = new ViaCepClient().Search(cep);
            
            txtEstado.Text = resultado.StateInitials;
        }
    }
}
