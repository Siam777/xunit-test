using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XUnitDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "I am in home";
        }
    }
}
