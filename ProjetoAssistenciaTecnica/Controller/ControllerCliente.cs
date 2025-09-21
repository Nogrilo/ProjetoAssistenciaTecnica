using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Importar o SQL no codigo
using ProjetoAssistenciaTecnica.Model;
using System.Windows.Forms;

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
                string sql = "";
                if (obj.modalidade == "Cliente")
                {
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
                }
                else if (obj.modalidade == "Funcionario")
                {
                    sql = @"call sp_insert_funcionario (
                        @nome,
                        @cpf_cnpj,
                        @telefone,
                        @email,
                        DATE_FORMAT(@data_nascimento, '%Y/%m/%d')
                    );";
                }
                else
                {
                    MessageBox.Show("Modalidade invalida!");
                    return false;
                }

                
                MySqlCommand executa = new MySqlCommand(sql, conexao);
                executa.Parameters.AddWithValue("@nome", obj.nome);
                executa.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executa.Parameters.AddWithValue("@telefone", obj.telefone);
                executa.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executa.Parameters.AddWithValue("@email", obj.email);

                // Passando os parametros de endereco

                executa.Parameters.AddWithValue("@estado", obj.endereco.estado);
                executa.Parameters.AddWithValue("@municipio", obj.endereco.municipio);
                executa.Parameters.AddWithValue("@bairro", obj.endereco.bairro);
                executa.Parameters.AddWithValue("@rua", obj.endereco.rua);
                executa.Parameters.AddWithValue("@complemento", obj.endereco.complemento);
                executa.Parameters.AddWithValue("@n_complemento", obj.endereco.n_casa);
                executa.Parameters.AddWithValue("@cep", obj.endereco.cep);

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
