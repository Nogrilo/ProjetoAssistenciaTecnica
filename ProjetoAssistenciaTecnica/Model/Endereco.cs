using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Endereco
    {
        public int idEndereco { get; set; } = 0;
        public string estado { get; set; } = string.Empty;
        public string municipio { get; set; } = string.Empty;
        public string cep { get; set; } = string.Empty;
        public string rua { get; set; } = string.Empty;
        public string bairro { get; set; } = string.Empty;
        public string complemento { get; set; } = string.Empty;
        public string n_casa { get; set; } = string.Empty;
        public int id_pertencente { get; set; } = 0;
    }
}
