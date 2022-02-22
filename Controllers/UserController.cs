using ApprooviaApi.Models;
using ApprooviaApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApprooviaApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public ActionResult<User> PostUser(User user) => _userService.PostUser(user);
    }
}