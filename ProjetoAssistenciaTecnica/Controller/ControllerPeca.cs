using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Controller
{
    public class ControllerPeca
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao;

        public ControllerPeca()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarPeca(Peca obj)
        {
            try
            {
                /* Inserindo os dados na tabela de pessoa */
                string sqlPeca = @"insert into tb_estoque_peca (
                @tipo,
                @valor_custo,
                @valor_repasse,
                )";

                /* Inserindo os dados na tabela peca */

                MySqlCommand executaPeca = new MySqlCommand(sqlPeca, conexao);
                executaPeca.Parameters.AddWithValue("@nome", obj.tipo);
                executaPeca.Parameters.AddWithValue("@cpf_cnpj", obj.valorCusto);
                executaPeca.Parameters.AddWithValue("@telefone", obj.valorRepasse);

                /* Abrir a conexao */
                conexao.Open();
                executaPeca.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                return false;
            }
        }
    }
}
