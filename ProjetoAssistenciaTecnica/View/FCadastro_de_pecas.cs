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
    public partial class FCadastro_de_pecas : Form
    {
        public FCadastro_de_pecas()
        {
            InitializeComponent();
        }

        public void limpar_campos()
        {
            txtNome.Clear();
            txtCusto.Clear();
            txtCustoRepasse.Clear();
        }

        private void botaoCadastrarPeca_Click(object sender, EventArgs e)
        {
            Peca obj = new Peca();


            /* Verificar se todos os campos foram preenchidos */

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                MessageBox.Show("Preencha o Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustoRepasse.Text))
            {
                MessageBox.Show("Preencha o Valor de Venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            obj.tipo = txtNome.Text;
            obj.valorCusto = float.Parse(txtCusto.Text);
            obj.valorRepasse = float.Parse(txtCustoRepasse.Text);

            ControllerPeca controllerPeca = new ControllerPeca();

            bool verificar_cadastro_peca = controllerPeca.cadastrarPeca(obj);

            if (verificar_cadastro_peca)
            {
                MessageBox.Show($"Peça {obj.tipo} Cadastrada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar_campos();
            }
        }
    }
}
