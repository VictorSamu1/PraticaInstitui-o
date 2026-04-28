using System.Collections.Generic;



namespace PraticaInstituição
{
    internal interface IRepository<T>
    {
        T ObterPorId(string id);
        IEnumetable <T> ObterTodos();
        void Gravar(T objeto);
        void Remover(T objeto);
    }
}
