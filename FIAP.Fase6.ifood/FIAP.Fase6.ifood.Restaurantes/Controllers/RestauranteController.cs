using FIAP.Fase6.ifood.Restaurantes.Application.Interfeces;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestauranteService _restauranteService;

        public RestauranteController(IRestauranteService restauranteService)
        {
            _restauranteService = restauranteService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(RestauranteViewModel restauranteViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                restauranteViewModel.Id = await _restauranteService.Create(restauranteViewModel);

                return Ok(restauranteViewModel);
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
                return Ok(await _restauranteService.Get(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAll(bool? ativo = null)
        {
            try
            {
                return Ok(await _restauranteService.GetAll(ativo));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(RestauranteViewModel restauranteViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values);
                }

                return Ok(await _restauranteService.Update(restauranteViewModel));
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
                return Ok(await _restauranteService.Delete(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
