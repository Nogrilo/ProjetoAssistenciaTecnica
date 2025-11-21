using MySql.Data.MySqlClient;
using ProjetoAssistenciaTecnica.Controller;
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
    public partial class FCadastro_ordem_servico : Form
    {

        public FCadastro_ordem_servico()
        {
            InitializeComponent();
        }

        private void txtCPFcnpj_Leave(object sender, EventArgs e)
        {
            /* Funcao que ao sair do txt de CPF, dar o select no banco */
            ControllerOrdemDeServico controllerOrdemDeServico = new ControllerOrdemDeServico();
            var pessoa = controllerOrdemDeServico.buscarPessoa(txtCPFcnpj.Text);
            if (pessoa != null )
            {
                txtNome.Text = pessoa.nome;
                txtRua.Text = pessoa.endereco.rua;
                txtBairro.Text = pessoa.endereco.bairro;
                maskedTelefone.Text = pessoa.telefone;
                txtMunicipio.Text = pessoa.endereco.municipio;
                txtNumeroCasa.Text = pessoa.endereco.n_casa;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }
    }
}
