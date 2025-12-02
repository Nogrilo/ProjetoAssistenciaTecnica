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

            obj.cpf_cliente = txtCPFCliente.Text;
            obj.marca = txtMarca.Text;
            obj.modelo = txtModelo.Text;
            obj.n_serie = txtNumeroSerie.Text;
            obj.tipo = txtTipo.Text;
            obj.condicao = txtCondicao.Text;

            ControllerProduto controllerProduto = new ControllerProduto();

            controllerProduto.cadastrarProduto(obj);

            MessageBox.Show($"Produto: {obj.modelo} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
