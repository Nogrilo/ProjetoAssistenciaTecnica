using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Ordem_servico
    {
        public int id_ordem_servico { get; set; } = 0;

        public int tick { get; set; } = 0;

        public int n_atendimento {  get; set; } = 0;

        public string defeito { get; set; } = string.Empty;

        public DateTime data_abertura { get; set; }

        public string acessorios { get; set; } = string.Empty;

        public string status { get; set; } = string.Empty;

        public int id_orcamento_inicial { get; set; } = 0;

        public string cpf_cliente { get; set; } = string.Empty;

        public int id_produto { get; set; } = 0;
    }
}
