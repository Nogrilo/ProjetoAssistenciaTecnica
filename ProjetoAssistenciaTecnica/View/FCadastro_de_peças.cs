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
    public partial class FCadastro_de_peças : Form
    {
        public FCadastro_de_peças()
        {
            InitializeComponent();
        }

        private void botaoCadastrarPeca_Click(object sender, EventArgs e)
        {
            Peca obj = new Peca();

            obj.tipo = txtNome.Text;
            obj.valorCusto = float.Parse(txtCusto.Text);
            obj.valorRepasse = float.Parse(txtCustoRepasse.Text);

            ControllerPeca controllerPeca = new ControllerPeca();

            controllerPeca.cadastrarPeca(obj);
            //MessageBox.Show("Pessoa Cadastrada com Sucesso!");
            //limparCampos();
        }
    }
}
