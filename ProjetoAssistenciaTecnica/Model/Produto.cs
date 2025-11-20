using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAssistenciaTecnica.Model
{
    public class Produto
    {
        public int idProduto { get; set; } = 0;

        public int id_pertencente { get; set; } = 0;

        public string marca { get; set; } = string.Empty;

        public string modelo { get; set; } = string.Empty;

        public string n_serie { get; set; } = string.Empty;

        public string tipo { get; set; } = string.Empty;
    }
}
