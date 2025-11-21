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
    class ControllerOrdemDeServico
    {
        /* Vincular ao banco de dados */
        private MySqlConnection conexao;

        public ControllerOrdemDeServico()
        {
            this.conexao = new Conexao().GetConnection();
        }

        public Pessoa buscarPessoa(string cpfCnpj)
        {
            string sql = @"SELECT 
                        p.nome,
                        p.cpf_cnpj,
                        p.telefone,
                        e.rua,
                        e.bairro,
                        e.n_complemento,
                        e.municipio
                    FROM tb_pessoa p
                    LEFT JOIN tb_endereco e ON p.idPessoa = e.id_pertencente
                    WHERE p.cpf_cnpj = @cpf
                    LIMIT 1;  
                    ";

            MySqlCommand executaCMD = new MySqlCommand(sql, conexao);
            executaCMD.Parameters.AddWithValue("@cpf", cpfCnpj); // Substituir o none na instrucao sql, com o nome

            conexao.Open(); // Abrir a conexao

            MySqlDataReader resultado = executaCMD.ExecuteReader();

            Pessoa pessoa = new Pessoa();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    pessoa.nome = resultado.GetString("nome");
                    pessoa.endereco.rua = resultado.GetString("rua");
                    pessoa.endereco.bairro = resultado.GetString("bairro");
                    pessoa.telefone = resultado.GetString("telefone");
                    pessoa.endereco.municipio = resultado.GetString("municipio");
                    pessoa.endereco.n_casa = resultado.GetString("n_complemento");

                }
                resultado.Close();
                conexao.Close();
                return pessoa;
            }
            else
            {
                resultado.Close();
                conexao.Close();
                return null;
            }
        }
    }
}
