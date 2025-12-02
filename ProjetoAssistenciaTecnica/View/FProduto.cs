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
    public partial class FProduto : Form
    {
        public FProduto()
        {
            InitializeComponent();
        }

        private void botaoCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            /* Verificar se todos os campos foram preenchidos */

            if (string.IsNullOrWhiteSpace(txtCPFCliente.Text))
            {
                MessageBox.Show("Preencha o CPF do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Preencha a marca do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Preencha o modelo do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                MessageBox.Show("Preencha o Número de Série do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("Preencha o tipo do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCondicao.Text))
            {
                MessageBox.Show("Preencha a condição do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.cpf_cliente = txtCPFCliente.Text;
            obj.marca = txtMarca.Text;
            obj.modelo = txtModelo.Text;
            obj.n_serie = txtNumeroSerie.Text;
            obj.tipo = txtTipo.Text;
            obj.condicao = txtCondicao.Text;

            ControllerProduto controllerProduto = new ControllerProduto();

            bool verificar_cadastro_produto = controllerProduto.cadastrarProduto(obj);

            /* Verificar se o cadastro foi feito com sucesso, se sim, vai retornar a mensagem */
            if (verificar_cadastro_produto)
            {
                MessageBox.Show($"Produto: {obj.modelo} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
