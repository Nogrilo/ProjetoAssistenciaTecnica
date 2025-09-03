using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Pessoa
    {
        public int idPessoa { get; set; }

        public string nome { get; set; }

        public string cpf_cnpj { get; set; }

        public string telefone { get; set; }

        public DateTime data_nascimento { get; set; }

        public DateTime data_cadastro { get; set; }
    }
}
