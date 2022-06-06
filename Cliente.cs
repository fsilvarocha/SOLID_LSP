using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public abstract bool ClientePremium();
    }
}
