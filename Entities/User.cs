using System;

namespace netAPI.Entities
{
  public record User
  {
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Password { get; init; }
    public DateTimeOffset UpdatedAt { get; init; }
    public DateTimeOffset CreatedAt { get; init; }

  }
}