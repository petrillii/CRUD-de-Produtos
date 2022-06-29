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

            if (product.img_principal.Length > 0 && product.img_secundary.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    product.img_principal.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    _product.principal_img = fileBytes;
                }
                using (var ms = new MemoryStream())
                {
                    product.img_secundary.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    _product.secundary_img = fileBytes;
                }
            }

            await productRepo.Create(_product);
        }

        public async Task<ResponseProductDto> GetProductById(int id)
        {
            var productEntity = await productRepo.GetById(id);
            var response = mapper.Map<ProductEntity, ResponseProductDto>(productEntity);
            return response;
        }

        public async Task<List<ResponseProductDto>> GetProducts()
        {
            var productEntity = await productRepo.GetAll();
            var products = mapper.Map<List<ProductEntity>, List<ResponseProductDto>>(productEntity);
            return products;
        }

        public async Task UpdateProduct(UpdateProductDto product)
        {
            
            var productEntity = await productRepo.GetById(product.id_product);
            
        }
    }
}
