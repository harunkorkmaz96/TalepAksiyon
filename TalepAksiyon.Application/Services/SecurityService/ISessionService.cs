using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Services.SecurityService;

public interface ISessionService
{
  void SetSession<T>(string key, T model);
  T GetSession<T>(string key);
  SessionModel GetUser();
  void SetUser(User user);
  SessionModel GetInjection();
  void CleanSession();
  ProjectSessionModel GetProject();
}
