using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Funcionario
    {
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string data_nascimento { get; set; }
        public string data_cadastro { get; set; }
        public int idFuncionario { get; set; }
        public int ativo { get; set; }
        public string dataAdmissao { get; set; }
        public string tipo { get; set; }
        public string codigoFuncionario { get; set; }
        public float porcentagemComissao { get; set; }
    }
}
