using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demeter
{
    internal class AmbienteProfissional: Ambiente
    {
        public List<RedeEletrica> RedeEletrica { get; private set; }
    }
}
