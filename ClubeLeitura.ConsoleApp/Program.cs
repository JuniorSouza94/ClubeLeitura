using ClubeLeitura.ConsoleApp.Métodos;

namespace ClubeLeitura.ConsoleApp
{
    public class Program
    {
        private static string _opcao;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("============= MENU =============");
                Console.WriteLine("[1] -> Cadastrar Caixa");
                Console.WriteLine("[2] -> Cadastrar Revista");
                Console.WriteLine("[3] -> Visualizar revistas");
                Console.WriteLine("[4] -> Cadastrar amigo");
                Console.WriteLine("[5] -> Visualizar amigos");
                Console.WriteLine("[6] -> Cadastrar empréstimo");
                Console.WriteLine("[7] -> Visualizar empréstimos");
                Console.WriteLine("[8] -> Devolução de empréstimo");
                Console.WriteLine("[0] -> Sair");
                Console.Write("=> ");
                _opcao = Console.ReadLine();

                switch (_opcao)
                {
                    case "1":
                        Console.Clear();
                        Metodos.CadastrarCaixa(); ;
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Metodos.CadastrarRevista();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Metodos.VisualizarRevistas();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Metodos.CadastrarAmigo();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Metodos.VisualizarAmigos();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Metodos.CadastrarEmprestimo();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Metodos.VisualizarEmprestimos();
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        Metodos.DevolverEmprestimo();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Até mais...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        Console.WriteLine("Aperte qualquer tecla para retornar.");
                        Console.ReadKey();
                        break;
                }
            } while (_opcao != "0");
        }                                       
    }
}
