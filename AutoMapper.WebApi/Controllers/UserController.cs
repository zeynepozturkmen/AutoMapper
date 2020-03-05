using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.WebApi.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            // Populate the user details from DB

            var user = new User();
            user.FirstName = "Zeynep";
            user.LastName = "zz";
            user.Email = "zz@gmail.com";

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            return Ok(userViewModel);
        }
    }
}