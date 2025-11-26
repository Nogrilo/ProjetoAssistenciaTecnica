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
            ControllerPessoa controller = new ControllerPessoa();
            var pessoa = controller.buscarPessoa(txtCPFcnpj.Text);
            if (pessoa != null)
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

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            /* Funcao que ao sair do txt de CPF, dar o select no banco */
            ControllerProduto controller = new ControllerProduto();
            var produto = controller.buscarProduto(txtModelo.Text);
            if (produto != null)
            {
                txtMarca.Text = produto.marca;
                txtNSerie.Text = produto.n_serie;
                comboCondicao.Text = produto.condicao;
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }
    }
}
