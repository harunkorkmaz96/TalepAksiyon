using Microsoft.EntityFrameworkCore;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Persistance.TalepAksiyonContextes;
using TalepAksiyon.Domain.Enums;

namespace TalepAksiyon.Infasctructure.Repositories;

public class SecurityRepository : ISecurityRepository
{
  private readonly TalepAksiyonContext _context;

  public SecurityRepository(TalepAksiyonContext context)
  {
    _context = context;
  }
  public async Task<User> Login(string username, string password)
  {
    return await _context.Users.FirstOrDefaultAsync(t => (t.Username == username || t.Email == username) && t.Password == password && t.ObjectStatus == ObjectStatus.NonDeleted && t.Status == Status.Active);
  }
}
