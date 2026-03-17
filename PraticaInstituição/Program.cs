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

        Console.Write("Pressione qualquer tecla para continuar");
        Console.ReadKey();

    }
}