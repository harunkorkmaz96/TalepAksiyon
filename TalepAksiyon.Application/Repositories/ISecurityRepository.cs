using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public interface ISecurityRepository
{
  Task<User> Login(string username, string password);

}
