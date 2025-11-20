using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;
using System.Windows.Forms;
using System.Data;

namespace ProjetoAssistenciaTecnica.Controller
{
    class ControllerProduto
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao;

        public ControllerProduto()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarProduto(Produto produto)
        {
            try
            {
                string sql = "";
                sql = @"call sp_insert_produto (
                    @id_pertencente,
                    @marca,
                    @modelo,
                    @n_serie,
                    @tipo,
                    @condicao
                    );";

                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@id_pertencente", produto.id_pertencente);
                executa.Parameters.AddWithValue("@marca", produto.marca);
                executa.Parameters.AddWithValue("@n_serie", produto.n_serie);
                executa.Parameters.AddWithValue("tipo", produto.tipo);
                executa.Parameters.AddWithValue("@condicao", produto.condicao);

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
