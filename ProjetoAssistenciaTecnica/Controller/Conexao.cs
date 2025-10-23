using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoAssistenciaTecnica
{
    public class Conexao
    {
        public MySqlConnection GetConnection()
        {
            string conexao = "server=localhost;" + "user=root; password=mitona;" + "database=db_eletro;";
            return new MySqlConnection(conexao);
        }
    }
}
