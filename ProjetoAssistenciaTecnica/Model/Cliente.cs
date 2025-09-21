using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Cliente : Pessoa
    {
        public int idCliente { get; set; } = 0;

        public string nome { get; set; } = string.Empty;

        public string cpf_cnpj { get; set; } = string.Empty;

        public string telefone { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public string data_nascimento { get; set; } = string.Empty;

        public string data_cadastro { get; set; } = string.Empty;
    }
}
