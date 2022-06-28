using AutoMapper;
using LojaJet.BLL.Infra.Services.Interfaces;
using LojaJet.Models.Dto;
using LojaJet.Models.Dto.Response;
using LojaJet.Models.Entities;
using LojaJet.Repository.Infra.Repositories.Interfaces;

namespace LojaJet.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepo;
        public ProductService(
            IMapper _mapper,
            IProductRepository _productRepo
        )
        {
            mapper = _mapper;
            productRepo = _productRepo;
        }
        public async Task CreateProduct(ProductDto product)
        {
            ProductEntity _product = mapper.Map<ProductDto, ProductEntity>(product);
            await productRepo.Create(_product);
        }

        public async Task<List<ResponseProductDto>> GetProducts()
        {
            var productEntity = await productRepo.GetAll();
            var products = mapper.Map<List<ProductEntity>, List<ResponseProductDto>>(productEntity);
            return products;
        }

    }
}
