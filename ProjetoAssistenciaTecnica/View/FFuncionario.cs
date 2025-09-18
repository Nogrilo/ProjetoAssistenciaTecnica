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
    public partial class FFuncionario : Form
    {
        public FFuncionario()
        {
            InitializeComponent();
        }

        public void habilitarCampos()
        {
            txtID.Enabled = false;
            txtNomeFuncionario.Enabled = true;
            txtCPFFuncionario.Enabled = true;
            txtTelefoneFuncionario.Enabled = true;
            txtDataNascimentoFuncionario.Enabled = true;
            txtEmailFuncionario.Enabled = true;
        }

        public void limparCampos()
        {
            txtID.Clear();
            txtNomeFuncionario.Clear();
            txtCPFFuncionario.Clear();
            txtTelefoneFuncionario.Clear();
            txtDataNascimentoFuncionario.Clear();
            txtEmailFuncionario.Clear();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            /* Atributos de Pessoa */
            Funcionario obj = new Funcionario();
            obj.nome = txtNomeFuncionario.Text;
            obj.cpf_cnpj = txtCPFFuncionario.Text;
            obj.telefone = txtTelefoneFuncionario.Text;
            obj.data_nascimento = txtDataNascimentoFuncionario.Text;
            obj.email = txtEmailFuncionario.Text;

            /* Atributos de Funcionario */
            //obj.idPessoa = int.Parse(txtIDPessoa.Text); // Converter int para TXT
            //obj.ativo = int.Parse(txtAtivo.Text);
            obj.tipo = comboTipo.Text;
            //obj.dataAdmissao = txtDataAdmissao.Text;
            //obj.codigoFuncionario = txtCodigoFuncionario.Text;
            //obj.porcentagemComissao = float.Parse(txtPorcentagem.Text); // Converter float para TXT

            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();

            controllerFuncionario.cadastrarFuncionario(obj);
            MessageBox.Show("Funcionario Cadastrado com sucesso");
        }
    }
}
