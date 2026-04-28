using PraticaInstituição;

internal class Program
{
    private static void Main(string[] args)
    {
        var iesUTFPR = new Instituicao()
        {

            Nome = "UTFPR",
            Endereco = new Endereco()
            {
                Rua = "Francisqueto",
                Numero = "676"
                
            }
            
        };


        var iesCC = new Instituicao() {
            Nome = "Casa do Código",
            Endereco = new Endereco() {
                Rua = "Robertino",
                Numero = "700"
            }
        };

        var dptoEnsino = new Departamento("Computação");
        

        var dptoAlimentos = new Departamento("Alimentos");
        

        var dptoRevisao = new Departamento("Revisão Escrita ");
       

        iesUTFPR.RegistrarDepartamento(dptoEnsino);
        iesUTFPR.RegistrarDepartamento(dptoAlimentos);

        Console.WriteLine("UTFPR");
        for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++)
        {
            Console.WriteLine($"=> {iesUTFPR.Departamentos[i].Nome}");
        }

        Console.WriteLine("Casa do Código");
        for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
        {
            Console.WriteLine($"=> {iesCC.Departamentos[i].Nome}");
        }
        dptoAlimentos.RegistrarCursos(
         new Curso { Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 });

        dptoAlimentos.RegistrarCursos(
        new Curso { Nome = "Engenharia de Alimentos", CargaHoraria = 3000 });

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}");

        foreach (var curso in dptoAlimentos.Cursos)
        {
            Console.WriteLine($"=> {curso.Nome} ({curso.CargaHoraria}h)");
        }

        dptoAlimentos.FecharDepartamento();
        dptoAlimentos = null;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("O departamento de alimentos foi fechado");
       
       

        var ctAlimentos = new Curso()
        {
            Nome = "Tecnologia em Alimentos",
            CargaHoraria = 2000
        };
        if (!dptoAlimentos.Cursos.Contains(ctAlimentos))
            dptoAlimentos.RegistrarCursos(ctAlimentos);

        Console.WriteLine();
        var cursoCC = new Curso() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
        cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Algoritmos", CargaHoraria = 80 });
        cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 60 });
        cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 80 });
        cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Estrutura de Dados", CargaHoraria = 80 });
        cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Programação para web", CargaHoraria = 80 });
        Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas:");
        foreach (var d in cursoCC.Disciplinas)
        {
            Console.WriteLine($"=> {d.Nome} ({d.CargaHoraria})");
        }
        Console.ReadKey();
    }
}