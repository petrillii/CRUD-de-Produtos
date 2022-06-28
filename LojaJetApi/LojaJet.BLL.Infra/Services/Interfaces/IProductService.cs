using LojaJet.Models.Dto;
using LojaJet.Models.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.BLL.Infra.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ResponseProductDto>> GetProducts();
        Task CreateProduct(ProductDto product);
    }
}
