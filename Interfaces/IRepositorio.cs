using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);

        void Insere(T entidade);
        void Exclui(int Id);
        void Atualiza(int ind, T entidade);
        int ProximoId();
        
         
    }
}