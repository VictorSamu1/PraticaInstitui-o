using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaInstituição
{
    abstract class PosGraduacao : Curso
    {
        public int Creditos { get; set; }
    }
}