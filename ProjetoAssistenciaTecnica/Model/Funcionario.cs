using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Funcionario : Pessoa
    {
        public int idFuncionario { get; set; } = 0;
        public int ativo { get; set; } = 0;
        public string dataAdmissao { get; set; } = string.Empty;
        public string tipo { get; set; } = string.Empty;
        public string codigoFuncionario { get; set; } = string.Empty;
        public float porcentagemComissao { get; set; } = 0;
    }
}
