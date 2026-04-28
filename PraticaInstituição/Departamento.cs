using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PraticaInstituição
{
    class Departamento
    {
        public string Nome { get; set; }

        public Departamento(string nome)
        {
            this.Nome = nome;


        }
        public IList<Curso> Cursos { get; } = new List<Curso>();

        public void RegistrarCursos(Curso c)
        {
            Cursos.Add(c);
        }

        public int ObterQuantidadeDeCursos()
        {
            return Cursos.Count;
        }

        public Curso ObterCursoPorIndice(int indice)
        {
            return Cursos[indice];
        }


        public void FecharDepartamento()
        {
            while (Cursos.Count > 0)
            {
                Cursos.RemoveAt(0);
            }
        }

        public Curso ObterCursoPorNome(string nome)
        {
            return Cursos.Where<Curso>(nameo => nameo.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}