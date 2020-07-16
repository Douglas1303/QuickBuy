using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contrates
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        void ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos(); 
    }
}
