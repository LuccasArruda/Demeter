using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demeter
{
    internal class AmbientePessoal: Ambiente
    {
        public RedeEletrica RedeEletrica { get; private set; }
    }
}
