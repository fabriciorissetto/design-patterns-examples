using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter.Errado
{
    public class Cliente
    {
        public Carteira Carteira { get; set; }
        public string Nome { get; set; }
    }
}
