using Criptografador.data.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Criptografador.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _repositorio;
        
        
        public ClienteController(IClienteRepositorio repositorio )
        {
            _repositorio = repositorio;
            
        }
        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var resposta = await _repositorio.BuscarTodosAsync();
            return Ok(resposta);
        }
    }
}