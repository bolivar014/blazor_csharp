using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : Controller
    {

        [HttpGet("{id}")] // Decorador de tipo de metodo a realizar
        public string Get(int id)
        {
            return id switch
            {
                1 => "Camilo",
                2 => "Valdes",
                _ => throw new NotSupportedException("El id es invalido...")
            };
        }

        
        [HttpPost] // Metodo POST para la creación de registros
        public string Post(PerfilPersonalDto perfilPersonal)
        {
            // Guardar el perfil personal
            return perfilPersonal.Nombre;
        }
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
