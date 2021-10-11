using Microsoft.AspNetCore.Mvc;
using netAPI.Repositories;
using System.Collections.Generic;
using netAPI.Entities;

namespace netAPI.Controllers
{
  [ApiController]
  [Route("users")]
  public class UsersController : ControllerBase
  {
    private readonly InMemUsersRepository repository;

    public UsersController()
    {
      repository = new InMemUsersRepository();
    }

    [HttpGet]
    public IEnumerable<User> GetUsers()
    {
      var users = repository.GetUsers();
      return users;
    }
  }
}