using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.Métodos
{
    public static class Metodos
    {
        private static List<Caixa> _caixas = new List<Caixa>();
        private static List<Revista> _revistas = new List<Revista>();
        private static List<Amigo> _amigos = new List<Amigo>();
        private static List<Emprestimo> _emprestimos = new List<Emprestimo>();
        public static void CadastrarCaixa()
        {
            Console.Clear();
            Caixa caixaCadastrada = new Caixa();
            Console.WriteLine("===== CADASTRO DE CAIXA =====");

            Console.Write("Cor da Caixa: ");
            caixaCadastrada.Cor = Console.ReadLine();

            Console.Write("Classificação da Etiqueta: ");
            caixaCadastrada.Etiqueta = Console.ReadLine();

            _caixas.Add(caixaCadastrada);

            Console.WriteLine("\nCadastro realizado com sucesso!");
        }
        public static void CadastrarRevista()
        {

            Console.Clear();
            Revista revistaCadastrada = new Revista();

            Console.WriteLine("===== CADASTRO DE REVISTA =====");

            Console.Write("Título da revista: ");
            revistaCadastrada.Titulo = Console.ReadLine();

            Console.Write("Nº Edição da revista: ");
            revistaCadastrada.NumeroEdicao = int.Parse(Console.ReadLine());

            Console.Write("Ano da Revista");
            revistaCadastrada.Ano = int.Parse(Console.ReadLine());

            int numeroCaixa;
            bool conversaoSucesso = false;
            Caixa caixaSelecionada = null;

            while (!conversaoSucesso)
            {
                Console.Write("Número da caixa: ");

                try
                {
                    numeroCaixa = int.Parse(Console.ReadLine());
                    caixaSelecionada = _caixas.Find(c => c.IdCaixa == numeroCaixa);
                    conversaoSucesso = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Número da caixa inválido. Por favor, informe novamente.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Erro: Número da caixa não pode ser nulo. Por favor, informe novamente.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}. Por favor, informe novamente.");
                }
            }

            revistaCadastrada.CaixaId = caixaSelecionada;

            _revistas.Add(revistaCadastrada);
            Console.WriteLine("\nCadastro realizado com sucesso!");
        }
        public static void VisualizarRevistas()
        {
            Console.Clear();
            Console.WriteLine("===== REVISTAS CADASTRADAS =====");

            List<Revista> revistas = _revistas;
            List<Caixa> caixas = _caixas;

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine("\n===== Caixa =====\n");
                Console.WriteLine($"Etiqueta: {caixa.Etiqueta}");
                Console.WriteLine($"Cor: {caixa.Cor}");

                foreach (Revista revista in revistas)
                {
                    if (revista.CaixaId == caixa)
                    {
                        Console.WriteLine("\n===== Revista =====\n");
                        Console.WriteLine($"Título: {revista.Titulo}");
                        Console.WriteLine($"Tipo de Coleção: {revista.TipoColecao}");
                        Console.WriteLine($"Edição: {revista.NumeroEdicao}");
                        Console.WriteLine($"Ano: {revista.Ano}");
                        Console.WriteLine("--------------------------------------------------------------------------------------------\n");

                    }
                }
            }
        }
        public static void CadastrarAmigo()
        {
            Console.Clear();
            Amigo amigoCadastrado = new Amigo();
            Console.WriteLine("===== CADASTRO DE AMIGOS =====");

            Console.Write("Nome do Amigo: ");
            amigoCadastrado.Nome = Console.ReadLine();

            Console.Write("Nome do Responsável: ");
            amigoCadastrado.NomeResponsavel = Console.ReadLine();

            Console.Write("Telefone: ");
            amigoCadastrado.Telefone = Console.ReadLine();

            Console.Write("Endereço: ");
            amigoCadastrado.Endereco = Console.ReadLine();

            _amigos.Add(amigoCadastrado);
            Console.WriteLine("\nCadastro realizado com sucesso!");
        }
        public static void VisualizarAmigos()
        {
            Console.Clear();
            Console.WriteLine("===== AMIGOS CADASTRADOS =====");

            foreach (var item in _amigos)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Nome do Responsável: {item.NomeResponsavel}");
                Console.WriteLine($"Telefone: {item.Telefone}");
                Console.WriteLine($"Endereço: {item.Endereco}");
                Console.WriteLine("-------------------------------------------\n");
            };
        }
        public static void CadastrarEmprestimo()
        {
            Console.Clear();
            Emprestimo emprestimo = new Emprestimo();

            Console.WriteLine("===== CADASTRO DE EMPRÉSTIMO =====");

            int idAmigo;
            bool conversaoSucesso = false;
            Amigo amigoSelecionado = null;

            while (!conversaoSucesso)
            {
                Console.Write("ID do amigo: ");

                try
                {
                    idAmigo = int.Parse(Console.ReadLine());
                    amigoSelecionado = _amigos.Find(a => a.IdAmigo == idAmigo);
                    conversaoSucesso = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: ID do amigo inválido. Por favor, informe novamente.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Erro: ID do amigo não pode ser nulo. Por favor, informe novamente.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}. Por favor, informe novamente.");
                }
            }

            emprestimo.Amigo = amigoSelecionado;

            int idRevista;
            conversaoSucesso = false;
            Revista revistaSelecionada = null;

            while (!conversaoSucesso)
            {
                Console.Write("ID da revista: ");

                try
                {
                    idRevista = int.Parse(Console.ReadLine());
                    revistaSelecionada = _revistas.Find(r => r.IdRevista == idRevista);
                    conversaoSucesso = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: ID da revista inválido. Por favor, informe novamente.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Erro: ID da revista não pode ser nulo. Por favor, informe novamente.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}. Por favor, informe novamente.");
                }
            }

            emprestimo.Revista = revistaSelecionada;

            emprestimo.DataEmprestimo = DateTime.Now;

            _emprestimos.Add(emprestimo);

            Console.WriteLine("\nCadastro realizado com sucesso!");
        }
        public static void VisualizarEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("===== EMPRÉSTIMOS CADASTRADOS =====");

            foreach (Emprestimo emprestimo in _emprestimos)
            {
                Console.WriteLine("\n===== Empréstimo =====\n");
                Console.WriteLine($"Amigo: {emprestimo.Amigo.Nome}");
                Console.WriteLine($"Revista: {emprestimo.Revista.Titulo}");
                Console.WriteLine($"Data do Empréstimo: {emprestimo.DataEmprestimo}");
                Console.WriteLine($"Data da Devolução: {emprestimo.DataDevolucao}");
                Console.WriteLine($"Devolvido: {emprestimo.Devolvido}");
            }
        }
        public static void DevolverEmprestimo()
        {
            Console.WriteLine("===== DEVOLUÇÃO DE EMPRÉSTIMO =====");

            Console.Write("Informe o ID do empréstimo: ");
            int idEmprestimo = int.Parse(Console.ReadLine());

            Emprestimo emprestimoSelecionado = _emprestimos.Find(e => e.IdEmprestimo == idEmprestimo);

            if (emprestimoSelecionado == null)
            {
                Console.WriteLine("Empréstimo não encontrado!");
                return;
            }

            if (emprestimoSelecionado.Devolvido)
            {
                Console.WriteLine("Esta revista já foi devolvida!");
                return;
            }

            emprestimoSelecionado.Devolver();

            Console.WriteLine("Devolução realizada com sucesso!");
        }

    }
}
