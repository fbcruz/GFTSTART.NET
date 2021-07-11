using System.Collections.Generic;

namespace series.Interfaces
{
    public interface irepositorio<T>
    {
        List<T> Lista();

        T RetornaPorid(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int Proximoid();

         
    }
}