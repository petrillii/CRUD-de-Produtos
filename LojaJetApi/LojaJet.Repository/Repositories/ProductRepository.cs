using AutoMapper;
using LojaJet.Models.Contexts;
using LojaJet.Models.Entities;
using LojaJet.Repository.Infra.Repositories.Interfaces;
using RepositoryLojaJet.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Repository.Repositories
{
    public class ProductRepository: RepositoryLojaJet<ProductEntity>, IProductRepository
    {
        private readonly LojaJetContext db;
        private readonly IMapper mapper;
        public ProductRepository(LojaJetContext ctx): base(ctx)
        {

        }
    }
}
