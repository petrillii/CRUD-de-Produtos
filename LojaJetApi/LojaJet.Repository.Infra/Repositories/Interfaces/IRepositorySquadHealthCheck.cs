using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadHealthCheck.Repository.Infra.Repositories.Interfaces
{
    public interface IRepositoryLojaJet<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task<int> Delete(TEntity entity);
        Task<int> Create(TEntity entity);
        Task<int> Update(TEntity entidade);

    }
}
