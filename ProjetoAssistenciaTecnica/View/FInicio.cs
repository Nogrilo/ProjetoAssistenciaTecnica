using System.Windows.Forms;
using ProjetoAssistenciaTecnica.View; // Para aparecer o FCliente, e outros arquivos

namespace ProjetoAssistenciaTecnica
{
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
        }

        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            /* Abrindo a tela de cadastro de cliente */

            FCliente tela = new FCliente();

            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            /* Adicionar uma nova aba ja existente */
            tabControl1.TabPages.Add("Cliente");

            /* Identificar quantas abas ja existem abertas */
            int abas = tabControl1.TabPages.Count;

            /* Adicionar o formulario na ultima aba */
            tabControl1.TabPages[abas - 1].Controls.Add(tela);

            /* Redimensionar ara o tamanho total da aba */
            tela.Dock = DockStyle.Fill;

            /* Mostrar Janela */
            tela.Show();
            Refresh();

            /* Selecionar a aba recem criada */
            tabControl1.SelectedTab = tabControl1.TabPages[abas - 1];

            /* Adicionar um icone na aba*/
            tabControl1.TabPages[abas - 1].ImageIndex = 0;
        }

        private void botaoCadastrarPessoa_Click(object sender, EventArgs e)
        {
            /* Abrindo a tela de cadastro de cliente */

            FPessoa tela = new FPessoa();

            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            /* Adicionar uma nova aba ja existente */
            tabControl1.TabPages.Add("Pessoa");

            /* Identificar quantas abas ja existem abertas */
            int abas = tabControl1.TabPages.Count;

            /* Adicionar o formulario na ultima aba */
            tabControl1.TabPages[abas - 1].Controls.Add(tela);

            /* Redimensionar ara o tamanho total da aba */
            tela.Dock = DockStyle.Fill;

            /* Mostrar Janela */
            tela.Show();
            Refresh();

            /* Selecionar a aba recem criada */
            tabControl1.SelectedTab = tabControl1.TabPages[abas - 1];

            /* Adicionar um icone na aba*/
            tabControl1.TabPages[abas - 1].ImageIndex = 0;
        }
    }
}
