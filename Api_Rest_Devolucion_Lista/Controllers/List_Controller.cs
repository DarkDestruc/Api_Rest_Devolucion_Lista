using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Rest_Devolucion_Lista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class List_Controller : ControllerBase
    {
        private static List<string> helados = new List<string> { "Corneto", "Magnun", "Polito" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> GeList_Controller()
        {
            return Ok(helados);

        }

    }






}
