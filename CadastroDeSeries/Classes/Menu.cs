using System;

namespace CadastroDeSeries
{
    public class Menu
    {
        protected internal static void BoasVindas()
        {
            Console.WriteLine(Environment.NewLine + "Bem vindx ao Cadastro de Séries!");
        }

        protected internal static string MenuPrincipal()
		{
			Console.WriteLine(Environment.NewLine + "**Menu Principal**");
			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");

			Console.Write(Environment.NewLine + "Informe a opção desejada: ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

        protected internal static void Adeus()
        {
            Console.WriteLine(Environment.NewLine + "Obrigada por utilizar nossos serviços. Até a próxima!");
			Console.WriteLine("Pressione ENTER para sair");
			Console.ReadLine();
        }

        protected internal static void InsereAltera(int? id)
        {
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

			Console.Write(Environment.NewLine + "Digite o número do gênero de uma das opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            if(id != null) 
            {
                // !null == altera

                // TODO: perguntar se confirma a alteração com cópia da informação na tela

                // TODO: procurar por linha no id (caso exista)
                string obj = $"{id}|{entradaTitulo}|{(Genero)entradaGenero}|{entradaAno}|{entradaDescricao}|{false}";
			    
            }
            else
            {
                string obj = $"{Arquivo.ProximoId()}|{entradaTitulo}|{(Genero)entradaGenero}|{entradaAno}|{entradaDescricao}|{false}";
			    Arquivo.Escrever(obj);
            }
        }
    }
}