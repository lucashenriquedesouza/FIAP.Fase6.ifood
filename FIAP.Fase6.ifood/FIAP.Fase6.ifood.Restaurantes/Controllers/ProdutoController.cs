using FIAP.Fase6.ifood.Restaurantes.Application.Interfaces;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Guid idRestaurante, ProdutoViewModel produtoViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                produtoViewModel.Id = await _produtoService.Create(idRestaurante, produtoViewModel);

                return Ok(produtoViewModel);
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
                return Ok(await _produtoService.Get(id));
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
                return Ok(await _produtoService.GetAll(idRestaurante, ativo));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid idRestaurante, ProdutoViewModel produtoViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                return Ok(await _produtoService.Update(idRestaurante, produtoViewModel));
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
                return Ok(await _produtoService.Delete(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
