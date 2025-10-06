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
    class ControllerPessoa
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao; 

        public ControllerPessoa ()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public bool cadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                string sql = "";
                 sql = @"call sp_insert_cliente (
                    @nome,
                    @cpf_cnpj,
                    @telefone,
                    @email,
                    DATE_FORMAT(@data_nascimento,   '%Y/%m/%d'),
                    @estado,
                    @municipio,
                    @bairro,
                    @rua,
                    @complemento,
                    @n_complemento,
                    @cep
                    );";
                
                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@nome", pessoa.nome);
                executa.Parameters.AddWithValue("@cpf_cnpj", pessoa.cpf_cnpj);
                executa.Parameters.AddWithValue("@telefone", pessoa.telefone);
                executa.Parameters.AddWithValue("@data_nascimento", pessoa.data_nascimento);
                executa.Parameters.AddWithValue("@email", pessoa.email);

                // Passando os parametros de endereco

                executa.Parameters.AddWithValue("@estado", pessoa.endereco.estado);
                executa.Parameters.AddWithValue("@municipio", pessoa.endereco.municipio);
                executa.Parameters.AddWithValue("@bairro", pessoa.endereco.bairro);
                executa.Parameters.AddWithValue("@rua", pessoa.endereco.rua);
                executa.Parameters.AddWithValue("@complemento", pessoa.endereco.complemento);
                executa.Parameters.AddWithValue("@n_complemento", pessoa.endereco.n_casa);
                executa.Parameters.AddWithValue("@cep", pessoa.endereco.cep);

                conexao.Open();
                executa.ExecuteNonQuery();

                if (pessoa is Funcionario funcionario)
                {
                    string sqlFuncionario = @"call sp_insert_funcionario (
                        @tipo
                    );";

                    MySqlCommand executaFuncionario = new MySqlCommand(sqlFuncionario, conexao);

                    executaFuncionario.Parameters.AddWithValue("@tipo", funcionario.tipo);
                    executaFuncionario.ExecuteNonQuery();

                }
                conexao.Close();

                return true; // garante retorno se tudo deu certo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                return false;
            }
        }

        /* Funcao de buscar os dados no banco de dados */
        public DataTable listarPessoas()
        {
            try
            {
                DataTable tabelaPessoa = new DataTable();

                string comandoSql = "select * from tb_pessoa";

                MySqlCommand executaTabelaPessoa = new MySqlCommand(comandoSql, conexao);

                /* Abrir conexao */
                conexao.Open();
                executaTabelaPessoa.ExecuteNonQuery();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(executaTabelaPessoa);

                adaptador.Fill(tabelaPessoa);

                conexao.Close();

                return tabelaPessoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
