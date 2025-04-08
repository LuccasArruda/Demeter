using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deméter
{
    internal class Ambiente_Profissional: Ambiente
    {
        public List<Rede_Eletrica> RedeEletrica { get; private set; }
    }
}
