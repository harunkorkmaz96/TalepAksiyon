using TalepAksiyon.Domain.DTOModels.ResponsibleHelperModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public interface IProjectNoteRepository: IRepository
{
  public Task<string> ProjectNoteAdd(ProjectNote projectNote);
  public void Delete(int id);
  public Task<IQueryable<ProjectNote>> GetList();
  Task<List<ResponsibleDevextremeSelectListHelper>> GetProject();
}
