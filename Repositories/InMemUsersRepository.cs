using System;
using System.Collections.Generic;
using System.Linq;
using netAPI.Entities;

namespace netAPI.Repositories
{
    public class InMemUsersRepository{
      private readonly List<User> users = new()
      {
        new User {
          Id= Guid.NewGuid(),
          Name="Diego Lincoln",
          Password = "123",
          UpdatedAt = DateTimeOffset.UtcNow,
          CreatedAt = DateTimeOffset.UtcNow
          },
          new User {
          Id= Guid.NewGuid(),
          Name="Thiago",
          Password = "456",
          UpdatedAt = DateTimeOffset.UtcNow,
          CreatedAt = DateTimeOffset.UtcNow
          }
      };

      public IEnumerable<User> GetUsers()
      {
        return users;
      }

      public User GetUser(Guid id)
      {
        return users.Where(user => user.Id == id).SingleOrDefault();
      }
    }
}