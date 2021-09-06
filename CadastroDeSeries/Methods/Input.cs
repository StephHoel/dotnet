using System;

namespace CadastroDeSeries
{
    public class Input
    {
        protected internal static int Genero()
        {
            Console.WriteLine(); // para ganhar um espaço entre a entrada anterior e essa

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}- {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write(Environment.NewLine + "Digite o número do novo gênero: ");
            // int entradaGenero = int.Parse(Console.ReadLine());
            return int.Parse(Console.ReadLine());

            // return entradaGenero;
        }

        protected internal static string Titulo()
        {
            Console.Write("Informe o novo título: ");
            // string entradaTitulo = Console.ReadLine();
            return Console.ReadLine();

            // return entradaTitulo;
        }

        protected internal static int Ano()
        {
            Console.Write("Informe o novo ano de início (xxxx): ");
            // int entradaAno = int.Parse(Console.ReadLine());
            return int.Parse(Console.ReadLine());

            // return entradaAno;
        }


        protected internal static string Descricao()
        {
            Console.Write("Informe a nova descrição: ");
            // string entradaDescricao = Console.ReadLine();
            return Console.ReadLine();

            // return entradaDescricao;
        }

        protected internal static int Id()
        {
        	Console.Write("Digite o id da série: ");
			// int indiceSerie = int.Parse(Console.ReadLine());
			return int.Parse(Console.ReadLine());
        }
    }
}