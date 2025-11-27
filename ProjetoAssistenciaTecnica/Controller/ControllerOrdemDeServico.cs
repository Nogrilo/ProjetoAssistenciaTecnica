using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;
using ProjetoAssistenciaTecnica.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAssistenciaTecnica.Controller
{
    class ControllerOrdemDeServico
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao;

        public ControllerOrdemDeServico()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrar_ordem_servico(Ordem_servico ordem_servico)
        {
            try
            {
                string sql = "";
                sql = @"call sp_ordem_servico (
                    @n_atendimento,
                    @defeito,
                    @acessorios,
                    @status_pd,
                    @id_orc_inicial,
                    @cpf_cliente,
                    @id_produto
                    );";

                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@n_atendimento", ordem_servico.n_atendimento);
                executa.Parameters.AddWithValue("@defeito", ordem_servico.defeito);
                executa.Parameters.AddWithValue("@acessorios", ordem_servico.acessorios);
                executa.Parameters.AddWithValue("@status_pd", ordem_servico.status);
                executa.Parameters.AddWithValue("@id_orc_inicial", ordem_servico.id_orcamento_inicial);
                executa.Parameters.AddWithValue("@cpf_cliente", ordem_servico.cpf_cliente);
                executa.Parameters.AddWithValue("@id_produto", ordem_servico.id_produto);

                conexao.Open();
                executa.ExecuteNonQuery();
                conexao.Close();

                return true; // garante retorno se tudo deu certo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                return false;
            }
        }
    }
}
