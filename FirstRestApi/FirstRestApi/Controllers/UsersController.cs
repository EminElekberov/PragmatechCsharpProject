using FirstRestApi.Model;
using FirstRestApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IJWTManagerRepository jWTManagerRepository;
        public UsersController(IJWTManagerRepository jWTManager)
        {
            jWTManagerRepository = jWTManager;
        }


        [HttpGet]
        public List<string> Get()
        {
            var users = new List<string>
            {
                "Mina FARZALI",
                "Xeyal XXXX",
                "Fuad XXXX"
            };
            return users;

        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate(Users users)
        {
            var token = jWTManagerRepository.Authontentication(users);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
