using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model; 

namespace ProjetoAssistenciaTecnica.Controller
{
    class ControllerPessoa
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao; 

        public ControllerPessoa ()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarPessoa(Pessoa obj)
        {
            try
            {
                string sql = @"insert into tb_pessoa (
                nome,
                cpf_cnpj,
                telefone,
                data_nascimento,
                email
                ) 

                VALUES (
                @nome,
                @cpf_cnpj,
                @telefone,
                DATE_FORMAT(@data_nascimento,   '%d/%m/%Y'),
                @email
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
