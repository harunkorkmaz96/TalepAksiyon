using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public  interface IProjectRepository: IRepository
{
  public Task<string> AddProject(Project model);
  public void Delete(int id);
  public Task<IQueryable<Project>> GetList();
  ProjectSessionModel GetProjectKey(string key);
}
