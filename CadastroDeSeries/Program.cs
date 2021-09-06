using System;
using System.IO;
using System.Configuration;
using CadastroDeSeries;

namespace CadastroDeSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

			// ** Teste de Leitura de Arquivo **
			// Arquivo.Ler();
			// Arquivo.Escrever("Teste 1");
			// Arquivo.Ler();

			// ** Begin **
			Menu.BoasVindas();

            string opcaoUsuario = Menu.MenuPrincipal();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						// ListarSeries();
						Arquivo.Ler();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Menu.MenuPrincipal();
			}

			Menu.Adeus();
        }

        private static void ExcluirSerie()
		{
			Console.Write(Environment.NewLine + "Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write(Environment.NewLine + "Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.WriteLine(Environment.NewLine + "**Atualizar Série**");
		
			Console.Write(Environment.NewLine + "Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());
			
			Menu.InsereAltera(indiceSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine(Environment.NewLine + "**Lista de séries**");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? " *Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine(Environment.NewLine + "**Inserir Nova Série**");
			
			Menu.InsereAltera();
		}
    }
}
