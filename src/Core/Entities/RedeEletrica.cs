using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demeter
{
    internal class RedeEletrica
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        public List<Aparelho> Aparelho { get; private set; }
    }
}
