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
using ViaCep; /* Biblioteca do VIA CEP */

namespace ProjetoAssistenciaTecnica.View
{
    public partial class FPessoa : Form
    {
        public FPessoa()
        {
            InitializeComponent();
            habilitarCampos();

            /* Desabilitar o campo de cargo do funcionario */
            comboCargo.Enabled = false;
        }

        /* Funcao para habilitar os campos, EXCETO o ID */
        public void habilitarCampos()
        {
            txtID.Enabled = false;
            txtNome.Enabled = true;
            maskCPFcnpj.Enabled = true;
            maskedTelefone.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtEmail.Enabled = true;
        }

        /* Funcao para desabilitar os campos do funcionario */
        public void desabilitarCamposFuncionario()
        {
            /* Ele comecara desabilitado, e caso a modalidade da pessoa for funcionario, irá habilitar */

            if (comboModalidade.SelectedItem != null && comboModalidade.SelectedItem.ToString() == "Funcionario")
            {
                comboCargo.Enabled = true;
            }
            else
            {
                comboCargo.Enabled = false;
            }
        }

        /* Funcao para limpar os campos */
        public void limparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            maskCPFcnpj.Clear();
            maskedTelefone.Clear();
            txtDataNascimento.Clear();
            txtEmail.Clear();
        }

        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();

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


            // Verificar se o objeto que vamos instanciar vai ser Funcionario, ou cliente

            if (comboModalidade.Text == "Funcionario")
            {
                obj = new Funcionario();

                ((Funcionario)obj).tipo = comboCargo.Text;
            }
            else
            {
                obj = new Cliente();
            }

            ControllerPessoa controllerPessoa = new ControllerPessoa();

            controllerPessoa.cadastrarPessoa(obj);
            MessageBox.Show("Pessoa Cadastrada com Sucesso!");
            //limparCampos();
        }

        private void botaoBuscarCEP_Click(object sender, EventArgs e)
        {
            string cep = maskedCEP.Text;

            var resultado = new ViaCepClient().Search(cep);

            comboUF.Text = resultado.StateInitials;
            txtMunicipio.Text = resultado.City;
            txtRua.Text = resultado.Street;
            txtBairro.Text = resultado.Neighborhood;
        }

        private void comboModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            desabilitarCamposFuncionario();
        }

        private void maskCPFcnpj_TextChanged(object sender, EventArgs e)
        {
            /*
            /* Teste para alterar a mascara dependendo do numero de caracteres, CPF ou CNPJ 

            /* Definindo as varias 
            string maskCPF = "000.000.000-00";
            string maskCNPJ = "00.000.000/0000-00";

            string apenasNumeros = new string(maskCPFcnpj.Text.Where(char.IsDigit).ToArray());

            /* Verificar a quantidade de caracteres do campo, e apicar a mascara defvida 
            if (maskCPFcnpj.Text.Length <= 11)
            {
                maskCPFcnpj.Mask = maskCPF;
            }
            else
            {
                maskCPFcnpj.Mask = maskCNPJ;
            }
            */
        }

        private void botaoPesquisarPessoa_Click(object sender, EventArgs e)
        {
            ControllerPessoa controllerPessoa = new ControllerPessoa();
            dataGridView1.DataSource = controllerPessoa.listarPessoas();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
