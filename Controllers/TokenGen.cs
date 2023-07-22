using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskList.DTO;
using TaskList.IRepository;

namespace TaskList.Controllers
{
    public class TokenGen : Controller
    {  
       
        private readonly JwtTokenService _service;

        public TokenGen(JwtTokenService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Token")]
        [AllowAnonymous] 
        public IActionResult TokenGeneration(Token t)
        {
            _service.GenerateToken(t.Toekn);
            return Ok();
        }
        //[HttpGet]
        //[Authorize]
        //[Route("ToeknView")]
        //public IActionResult new()
        //{
        //    return null;
        //}

    }
}
