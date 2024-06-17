using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

//api/[controller] means that in the url we type Users -> /api/users 
[ApiController]
[Route("api/[controller]")] 
public class UsersController : ControllerBase
{
    // This is allowing us to use the variable throughout our code
    private readonly DataContext _context;

    //this will be "Injected" into our UsersController when userscontroller is created
    // so so basically when we get a HTTP request this will create a single instance tied to that request
    // and the controller will tell it what to do with the request
    public UsersController(DataContext context)
    {
       _context = context; 
    }
    
    //url -> /api/users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    //this endpoint will get one user depending on id entered in url
    //url -> /api/users/id
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }
}