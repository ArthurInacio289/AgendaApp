using AgendaApp.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var categoriaRepository = new CategoriaRepository();
            return Ok(categoriaRepository.GetAll());
        }
    }
}
