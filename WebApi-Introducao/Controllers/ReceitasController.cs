using Microsoft.AspNetCore.Mvc;

namespace WebApi_Introducao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceitasController : ControllerBase
    {
        [HttpGet]
        public string[] Index()
        {
            return BolosDaVovó().Union(Minhas()).OrderBy(receita => receita).ToArray();
        }

        [HttpGet(nameof(BolosDaVovó))]
        public string[] BolosDaVovó()
        {
            return new string[] { "Laranja", "Fubá", "Cenoura", "Chocolate" };
        }

        [HttpGet(nameof(Minhas))]
        public string[] Minhas()
        {
            return new string[] { "Pão de cebolete", "Cafeleite", "Batafrita" };
        }

        [HttpDelete("{todas}")]
        public ActionResult Delete(bool todas)
        {
            if (todas)
            {
                return BadRequest();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
