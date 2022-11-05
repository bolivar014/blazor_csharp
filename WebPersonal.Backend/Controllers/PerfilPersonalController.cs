using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.Backend.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : Controller
    {

        [HttpGet("LeerPerfil/{id}")] // Decorador de tipo de metodo a realizar
        public string Get(int id)
        {
            return id switch
            {
                1 => "Camilo",
                2 => "Valdes",
                _ => throw new NotSupportedException("El id es invalido...")
            };
        }
    }
}
