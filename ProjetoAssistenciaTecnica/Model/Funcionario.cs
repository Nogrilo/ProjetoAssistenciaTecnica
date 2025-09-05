using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Funcionario : Pessoa
    {
        public int idFuncionario { get; set; }
        public int ativo { get; set; }
        public string dataAdmissao { get; set; }
        public string tipo { get; set; }
        public string codigoFuncionario { get; set; }
        public float porcentagemComissao { get; set; }
    }
}
