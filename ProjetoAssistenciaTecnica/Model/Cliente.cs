using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Cliente
    {
        public int idCliente { get; set; }

        public string nome { get; set; }

        public string cpf_cnpj { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public string data_nascimento { get; set; }

        public string data_cadastro { get; set; }
    }
}
