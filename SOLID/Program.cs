using SOLID;
using SOLID.Interfaces;
using SOLID.Repositories;

class Program
{
    public static void Main(string[] args)
    {
        IRepositorio repositorio = new RepositorioFuncionarios(new List<Funcionario>());

        var programador = new Programador(id:0, nome:"Lucas", idade:20, altura:1.95, salario:3500.00, tecnologia:".NET");
        var analista = new Analista(id: 1, nome: "Felipe", idade: 20, altura: 1.95, salario: 3500.00);

        repositorio.Inserir(programador);
        repositorio.Inserir(analista);

        foreach (var funcionario in repositorio.ListarTodosFuncionarios())
        {
            Console.WriteLine($"{funcionario.Nome}");
        }
    }
}