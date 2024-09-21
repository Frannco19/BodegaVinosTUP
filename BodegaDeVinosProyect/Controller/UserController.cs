using BodegaDeVinosProyect.Entities;
using BodegaDeVinosProyect.Services;
using Microsoft.AspNetCore.Mvc;

namespace BodegaDeVinosProyect.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // Endpoint para crear un usuario
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null) return BadRequest("Campo/s de usuario en nulo");

            _userService.RegisterUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // Endpoint para obtener un usuario por ID (opcional)
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userService.GetAllUsers().FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound("El usuario no existe!");
            return Ok(user);
        }
    }

}
