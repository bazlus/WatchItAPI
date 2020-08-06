namespace WatchIt.API.Features.Identity
{
    using Microsoft.AspNetCore.Mvc;
    using WatchIt.API.Features.Base;

    public class IdentityController : ApiController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("It Works!");
        }
    }
}
