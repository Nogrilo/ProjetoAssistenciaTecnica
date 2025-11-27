using MySql.Data.MySqlClient;
using ProjetoAssistenciaTecnica.Controller;
using ProjetoAssistenciaTecnica.Model;
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

        private void botao_cadastrar_ordem_servico_Click(object sender, EventArgs e)
        {
            Ordem_servico obj = new Ordem_servico();
            /*
            obj.nome = txtNome.Text;
            obj.cpf_cnpj = maskCPFcnpj.Text;
            obj.telefone = maskedTelefone.Text;
            obj.data_nascimento = DateTime.Parse(txtDataNascimento.Text); // Converter para DateTime
            obj.email = txtEmail.Text;
            obj.modalidade = comboModalidade.Text;

            //Endereco
            obj.endereco.cep = maskedCEP.Text;
            obj.endereco.estado = comboUF.Text;
            obj.endereco.municipio = txtMunicipio.Text;
            obj.endereco.rua = txtRua.Text;
            obj.endereco.bairro = txtBairro.Text;
            obj.endereco.complemento = comboComplemento.Text.Trim();
            obj.endereco.n_casa = txtNumeroCasa.Text;

            ControllerPessoa controllerPessoa = new ControllerPessoa();

            controllerPessoa.cadastrarPessoa(obj);
            MessageBox.Show("Pessoa Cadastrada com Sucesso!");
            */
            //limparCampos();
        }
    }
}
