using System;
using System.IO;
using System.Configuration;

namespace CadastroDeSeries
{
   class Program
   {
		static SerieRepositorio repositorio = new SerieRepositorio();

		static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine(Environment.NewLine + "Bem vindx ao Cadastro de Séries!");

			string opcao = MenuPrincipal();

			while (opcao.ToUpper() != "X")
			{
				switch (opcao)
				{
					case "1": // lista todas as séries
						Arquivo.ListarTudo();
						break;
					case "2": // lista apenas séries não excluídas
						Arquivo.ListarNaoExcluida();
						break;
					case "3": // lista apenas séries excluídas
						Arquivo.ListarExcluida();
						break;
					case "4":
						Principal.InserirSerie();
						break;
					case "5":
						Principal.AtualizarSerie();
						break;
					case "6":
						Principal.ExcluirSerie();
						break;
					case "7":
						Principal.VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcao = MenuPrincipal();
			}

			Console.WriteLine(Environment.NewLine + "Obrigada por utilizar nossos serviços. Até a próxima!");
			Console.WriteLine("Pressione ENTER para sair");
			Console.ReadLine();
		}

		private static string MenuPrincipal()
		{
			Console.WriteLine(Environment.NewLine + "**Menu Principal**");
			Console.WriteLine("1- Listar todas as séries");
			Console.WriteLine("2- Listar apenas séries não excluídas");
			Console.WriteLine("3- Listar apenas séries excluídas");
			Console.WriteLine("4- Inserir nova série");
			Console.WriteLine("5- Atualizar série");
			Console.WriteLine("6- Excluir série");
			Console.WriteLine("7- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");

			Console.Write(Environment.NewLine + "Informe a opção desejada: ");
			string opcao = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcao;
		}

		private static string MenuLista()
		{
			Console.WriteLine(Environment.NewLine + "**Menu de Listas**");
			Console.WriteLine("1- Listar todos os Filmes e Séries");
			Console.WriteLine("2- Listar Filmes");
			Console.WriteLine("3- Listar Séries");
			Console.WriteLine("4- Listar todos Assistidos");
			Console.WriteLine("5- Listar todos Quero Assistir");
			Console.WriteLine("6- Voltar para o Menu Principal");
			Console.WriteLine("X- Sair");
		}
   }
}
