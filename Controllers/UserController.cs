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
        // I created the controller route that will trigger the PostUser to the database. 
        // Once a user goes to https://localhost:5001/User it will trigger the service to do the POST request 
        [HttpPost]
        public ActionResult<User> PostUser(User user) => _userService.PostUser(user);
    }
}