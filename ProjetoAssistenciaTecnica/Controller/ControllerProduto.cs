using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;
using System.Windows.Forms;
using System.Data;
using Google.Protobuf.WellKnownTypes;

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
                    @cpf_cliente,
                    @marca,
                    @modelo,
                    @n_serie,
                    @tipo,
                    @condicao
                    );";

                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@cpf_cliente", produto.cpf_cliente);
                executa.Parameters.AddWithValue("@marca", produto.marca);
                executa.Parameters.AddWithValue("@modelo", produto.modelo);
                executa.Parameters.AddWithValue("@n_serie", produto.n_serie);
                executa.Parameters.AddWithValue("@tipo", produto.tipo);
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

        public Produto buscarProduto(string modelo)
        {
            string sql = @"SELECT 
                        marca,
                        n_serie,
                        condicao,
                        idProduto
                        FROM tb_produto
                        WHERE modelo = @modelo
                        ";

            MySqlCommand executaCMD = new MySqlCommand(sql, conexao);
            executaCMD.Parameters.AddWithValue("@modelo", modelo); // Substituir o none na instrucao sql, com o nome

            conexao.Open(); // Abrir a conexao

            MySqlDataReader resultado = executaCMD.ExecuteReader();

            Produto produto = new Produto();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    produto.marca = resultado.GetString("marca");
                    produto.n_serie = resultado.GetString("n_serie");
                    produto.condicao = resultado.GetString("condicao");
                    produto.idProduto = resultado.GetInt16("idProduto");
                }
                return produto;
            }
            else
            {
                return null;
            }
            resultado.Close();
            conexao.Close();
        }
    }
}
