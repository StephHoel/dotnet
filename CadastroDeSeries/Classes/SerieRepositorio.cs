using System.Collections.Generic;
using CadastroDeSeries.Interfaces;

namespace CadastroDeSeries
{
   public class SerieRepositorio : IRepositorio<Serie>
	{
        private readonly List<Serie> listaSerie = new();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public static void Inserir(string objeto)
		{
			Arquivo.Escrever(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId() //inutilizado
		{
			// return listaSerie.Count;
			return Arquivo.ProximoId();
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}