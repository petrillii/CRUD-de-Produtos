using AutoMapper;
using LojaJet.BLL.Infra.Services.Interfaces;
using LojaJet.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaJet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductService srvc;
        public ProductController(
            IMapper _mapper,
            IProductService _srvc
        )
        {
            mapper = _mapper;
            srvc = _srvc;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await srvc.GetProducts());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm]ProductDto product)
        {
            try
            {
                await srvc.CreateProduct(product);
                return Ok("Produto criado com sucesso!");
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao criar o produto");
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDto product)
        {
            try
            {
             
                return await Task.FromResult(Ok("Produto atualizado com sucesso!"));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao atualizar o produto");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            try
            {
                
                return await Task.FromResult(Ok("Produto deletado com sucesso!"));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao deletar o produto");
            }

        }
    }
}
