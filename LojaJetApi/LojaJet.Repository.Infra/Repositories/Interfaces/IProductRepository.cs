using LojaJet.Models.Entities;
using SquadHealthCheck.Repository.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Repository.Infra.Repositories.Interfaces
{
    public interface IProductRepository : IRepositoryLojaJet<ProductEntity>
    {
    }
}
