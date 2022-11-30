using Microsoft.AspNetCore.Mvc;

namespace WebApi_Introducao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunosController : ControllerBase
    {
        [HttpGet]
        public string[] Chamada()
        {
            return new string[] { "Renato", "Igor", "Andressa", "João" };
        }
    }
}
