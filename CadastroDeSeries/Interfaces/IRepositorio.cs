using System.Collections.Generic;

namespace CadastroDeSeries.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere (T entidade);

         void Exclui(int id);

         voud Atualiza(int id, T entidade);

         int ProximoId();
    }
}