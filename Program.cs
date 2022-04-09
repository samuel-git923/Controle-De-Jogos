using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    public class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Controle de Jogos ===");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("[1] Cadastrar um jogo");
            Console.WriteLine("[2] Excluir um jogo");
            Console.WriteLine("[3] Alterar um jogo");
            Console.WriteLine("[4] Localizar um jogo por nome");
            Console.WriteLine("[5] Lista os jogo por gênero");
            Console.WriteLine("[6] Lista os jogo por console");
            Console.WriteLine("[7] Lista todos os jogos");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            ListaDeJogos listadejogos = new ListaDeJogos();
            List<Jogo> lista = new List<Jogo>(); // utilizado nos cases
            String nomejogo = "";
            int id = 0;

            // jogos para teste de sistema
            Jogo jogo = new Jogo(1, "Ty Runner", "Jogo de corrida infinita", TipoGenero.Aventura, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            jogo = new Jogo(2, "Jackpot", "Caça-Níquel", TipoGenero.Casual, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            jogo = new Jogo(3, "Faroeste Zumbi", "Jogo de tiro", TipoGenero.Acao, TipoConsole.PC);
            listadejogos.Inserir(jogo);

            int op = 0; // valor da operação que o usuário irá realizar
            while (op != 0)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1: // inserir
                        Console.WriteLine("Inserir um jogo");
                        jogo = new Jogo();
                        Console.Write("ID: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Descricao: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o genero Acao[0], Aventura[1], Casual[2], Puzzle[3], Estrategia[4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o console PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Inserir(jogo))
                        {
                            Console.WriteLine("Jogo inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo não inserido!");
                        }
                        Console.ReadKey();
                        break;

                    case 2: // excluir
                        Console.WriteLine("Exclui um jogo");
                        Console.Write("Informe o ID do jogo: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Excluir(id))
                        {
                            Console.WriteLine("Jogo excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo não excluído!");
                        }
                        Console.ReadKey();

                        break;

                    case 3: // alterar
                        Console.WriteLine("Alterar um jogo");
                        jogo = new Jogo();
                        Console.Write("ID: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Descricao: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o genero Acao[0], Aventura[1], Casual[2], Puzzle[3], Estrategia[4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o console PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Alterar(jogo))
                        {
                            Console.WriteLine("Jogo alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo não alterado!");
                        }
                        Console.ReadKey();
                        break;

                    case 4: // localizar por nome
                        Console.WriteLine("Localizar jogos");
                        Console.Write("Informe o nome do jogo: ");
                        nomejogo = Console.ReadLine();
                        lista = listadejogos.Localizar(nomejogo);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Gênero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }

                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5: // listar por gênero
                        Console.WriteLine("Listar todos os jogos por genero");
                        Console.Write("Informe o genero Acao[0], Aventura[1], Casual[2], Puzzle[3], Estrategia[4], Outro[5]: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListarPorGenero(genero);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Gênero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }

                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6: // listar por console
                        Console.WriteLine("Listar todos os jogos por console");
                        Console.Write("Informe o console PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6]: ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListarPorConsole(console);

                        foreach (var j in lista)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Gênero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }

                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7: // listar todos os jogos
                        Console.WriteLine("Listar todos os jogos");
                        foreach (var j in listadejogos.Jogos)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descrição: " + j.Descricao);
                            Console.Write(" - Gênero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
