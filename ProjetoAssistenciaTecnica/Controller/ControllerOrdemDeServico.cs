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
    }
}
