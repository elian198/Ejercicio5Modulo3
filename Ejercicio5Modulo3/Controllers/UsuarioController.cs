

using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ejercicio5Modulo3.Controllers
{

    [Route("api/v1/usuarios/")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _usuarioService;
        private readonly IConfiguration _config;
        private IHttpClientFactory _httpClientFactory;

        public UsuarioController(IUsuarioService usuarioService, IConfiguration config, IHttpClientFactory httpClientFactory)
        {
            _usuarioService = usuarioService;
            _config = config;
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        [Route("seed")]
        public async Task<ActionResult> LoadUser()
        {

            var client = _httpClientFactory.CreateClient("servicio-posts");
            var result = await client.GetAsync($"?results={_config.GetSection("SEED_RESULT_NUMBER").Value}");
            var content = await result.Content.ReadAsStringAsync();
            var resulDeserializado = JsonConvert.DeserializeObject<Random>(content);

            return Ok(_usuarioService.CargarEnBaseDeDatos(resulDeserializado.Results));
        }

        [HttpGet]
        public async Task<ActionResult>FindByFilter([FromQuery] Parameters parameters)
        {
            return Ok(await _usuarioService.findByFilter(parameters));
        }


    }
}