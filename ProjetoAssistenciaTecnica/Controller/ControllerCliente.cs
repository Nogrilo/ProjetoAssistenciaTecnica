using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model; 

namespace ProjetoAssistenciaTecnica.Controller
{
    class ControllerCliente
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao; 

        public ControllerCliente ()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarCliente(Cliente obj)
        {
            try
            {
                // Chamar a Procedure que o Filipe fez, que inseri os dados no banco, de forma melhorada

                string sql = @"call sp_insert_cliente( 
                @nome,
                @cpf_cnpj,
                @telefone,
                @email,
                DATE_FORMAT(@data_nascimento,   '%Y/%m/%d')
                );";

                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@nome", obj.nome);
                executa.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executa.Parameters.AddWithValue("@telefone", obj.telefone);
                executa.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executa.Parameters.AddWithValue("@email", obj.email);

                /* Abrir a conexao */
                conexao.Open();
                executa.ExecuteNonQuery();
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
