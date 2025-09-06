using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;

namespace ProjetoAssistenciaTecnica.Controller
{
    class ControllerFuncionario
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao;

        public ControllerFuncionario()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                /* Inserindo os dados na tabela de pessoa */
                string sqlPessoa = @"call sp_insert_cliente (
                @nome,
                @cpf_cnpj,
                @telefone,
                @email,
                DATE_FORMAT(@data_nascimento,   '%Y/%m/%d')
                )";

                /* Inserindo os dados na tabela pessoa */

                MySqlCommand executaPessoa = new MySqlCommand(sqlPessoa, conexao);
                executaPessoa.Parameters.AddWithValue("@nome", obj.nome);
                executaPessoa.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executaPessoa.Parameters.AddWithValue("@telefone", obj.telefone);
                executaPessoa.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executaPessoa.Parameters.AddWithValue("@email", obj.email);

                /* Abrir a conexao */
                conexao.Open();
                executaPessoa.ExecuteNonQuery();
                conexao.Close();

                /* Inserindo os dados na tabela de funcionario */
                string sqlFuncionario = @"call sp_insert_funcionario (
                @tipo
                );";

                MySqlCommand executaFuncionario = new MySqlCommand(sqlFuncionario, conexao);
                executaFuncionario.Parameters.AddWithValue("@id_pessoa", obj.idPessoa);
                executaFuncionario.Parameters.AddWithValue("@ativo", Convert.ToInt32(obj.ativo));
                executaFuncionario.Parameters.AddWithValue("@data_adimissao", obj.dataAdmissao);
                executaFuncionario.Parameters.AddWithValue("@tipo", obj.tipo);
                executaFuncionario.Parameters.AddWithValue("@codigo_funcionario", obj.codigoFuncionario);
                executaFuncionario.Parameters.AddWithValue("@porcentagem_comissao", obj.porcentagemComissao);


                /* Abrir a conexao */
                conexao.Open();
                executaFuncionario.ExecuteNonQuery();
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
