using TalepAksiyon.Domain.DTOModels.Entities.UserModel;
using TalepAksiyon.Domain.DTOModels.ResponsibleHelperModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public interface IUserRepository : IRepository
{
  public Task<string> AddUser(User user);
  public void Delete(int id);
  public Task<IQueryable<User>> GetList();
  Task<List<ResponsibleDevextremeSelectListHelper>> GetResponsible();
  Task<UserDetailDto> UserDetails(int ID);
}
