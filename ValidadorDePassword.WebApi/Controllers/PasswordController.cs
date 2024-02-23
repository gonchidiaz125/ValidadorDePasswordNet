using Microsoft.AspNetCore.Mvc;
using static ValidadorDePassword.ValidadorDePassword;

namespace ValidadorDePassword.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {           
        private readonly ILogger<WeatherForecastController> _logger;

        public PasswordController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ValidarPassword")]
        public ResultadoValidacion ValidarPassword(string password)
        {
            var validador = new ValidadorDePassword();
            var resultado = validador.ValidarPasswordConTodasSusReglas(password);
            return resultado;                
        }
    }
}


