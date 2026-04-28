using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaInstituição
{
    class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhasDePesquisa { get; } = new List<string>();
    }
}
