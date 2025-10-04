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

        public int idPesosa { get; set; } = 0;
    }
}
