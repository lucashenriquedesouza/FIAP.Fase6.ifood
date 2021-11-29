using FIAP.Fase6.ifood.Restaurantes.Application.Services;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Guid idRestaurante, EnderecoViewModel enderecoViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                enderecoViewModel.Id = await _enderecoService.Create(idRestaurante, enderecoViewModel);

                return Ok(enderecoViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return Ok(await _enderecoService.Get(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAll(Guid idRestaurante, bool? ativo = null)
        {
            try
            {
                return Ok(await _enderecoService.GetAll(idRestaurante, ativo));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid idRestaurante, EnderecoViewModel EnderecoViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                return Ok(await _enderecoService.Update(idRestaurante, EnderecoViewModel));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                return Ok(await _enderecoService.Delete(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
