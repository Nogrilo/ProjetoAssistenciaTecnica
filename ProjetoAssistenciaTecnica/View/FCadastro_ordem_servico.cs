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

            /* Verificar todos os campos foram preenchidos */

            if (string.IsNullOrWhiteSpace(txtCPFcnpj.Text))
            {
                MessageBox.Show("Preencha o CPF/CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                MessageBox.Show("Preencha a Rua", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Preencha o Bairro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(maskedTelefone.Text))
            {
                MessageBox.Show("Preencha o Telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text))
            {
                MessageBox.Show("Preencha o Municipio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroCasa.Text))
            {
                MessageBox.Show("Preencha o Número da Casa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
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
                MessageBox.Show("Pessoa não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            /* Funcao que ao sair do txt de Modelo, dar o select no banco */

            ControllerProduto controller = new ControllerProduto();
            var produto = controller.buscarProduto(txtModelo.Text);
            if (produto != null)
            {
                txtMarca.Text = produto.marca;
                txtNSerie.Text = produto.n_serie;
                comboCondicao.Text = produto.condicao;
                txt_id_produto.Text = produto.idProduto.ToString();
            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botao_cadastrar_ordem_servico_Click(object sender, EventArgs e)
        {
            Ordem_servico obj = new Ordem_servico();

            obj.n_atendimento = 1;
            obj.defeito = txtDefeito.Text;
            obj.acessorios = txtAcessorios.Text;
            obj.status = "Na fila para concerto";
            obj.id_orcamento_inicial = int.Parse(txt_id_orcamento.Text);
            obj.cpf_cliente = txtCPFcnpj.Text;
            obj.id_produto = int.Parse(txt_id_produto.Text);

            ControllerOrdemDeServico controller_ordem_servico = new ControllerOrdemDeServico();

            controller_ordem_servico.cadastrar_ordem_servico(obj);
            MessageBox.Show("Ordem de Servico Cadastrada com Sucesso!");
            
            //limparCampos();
        }
    }
}
