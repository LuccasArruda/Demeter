using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demeter
{
    internal class Aparelho
    {
        public double Potencia { get; private set; }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Tensao { get; private set; }
    }
}
