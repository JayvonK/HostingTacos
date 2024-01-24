using Microsoft.AspNetCore.Mvc;

namespace HostingTacos.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class TacoController : ControllerBase
    {
        [HttpGet]

        public string GetTacos()
        {
            return "5 chicken tacos with no toppings";
        }
    }
