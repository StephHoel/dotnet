using System;

namespace CadastroDeSeries
{
    public class Output
    {
        protected internal static void Titulo(string titulo)
        {
            Console.WriteLine($"**{titulo}**");
        }

        protected internal static string[] Split(string s)
        {
            return s.Split('|');
        }

        protected internal static void MenuPrincipal()
		{
         Console.WriteLine();
			Console.WriteLine("**Menu Principal**");
			Console.WriteLine("1- Listar todas as séries");
			Console.WriteLine("2- Listar apenas séries não excluídas");
			Console.WriteLine("3- Listar apenas séries excluídas");
			Console.WriteLine("4- Inserir nova série");
			Console.WriteLine("5- Atualizar série");
			Console.WriteLine("6- Excluir série");
			Console.WriteLine("7- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
		}

        protected internal static string RetornoMenu()
        {
            Console.WriteLine();
			Console.Write("Informe a opção desejada: ");
			string opcao = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcao;
        }
    }
}