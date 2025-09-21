using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Endereco
    {
        public int idEndereco { get; set; }

        public string estado { get; set; }

        public string municipio { get; set; }

        public string cep { get; set; }

        public string rua { get; set; }

        public string bairro { get; set; }

        public string complemento { get; set; }

        public string n_casa { get; set; }

        public int id_pertencente { get; set; }
    }
}
