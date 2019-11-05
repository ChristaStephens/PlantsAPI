using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

//namespace based on folder structure (root then folder)
namespace PlantsAPI.Controllers
{
    //inherits from controller base
    //not static
    //to show that it is actually a controller we need to decorate
    //it with "apicontroller"
    [ApiController]
    public class PlantsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}
