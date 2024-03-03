using System.Linq.Expressions;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public  interface IProjectRepository: IRepository
{
  public Project GetById(int id);
  public Task<Project> GetByIdAsync(int id);

  public Project Get(Expression<Func<Project, bool>> filter = null);
  public Task<Project> GetAsync(Expression<Func<Project, bool>> filter = null);

  public Project Get(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties);

  public Task<Project> GetAsync(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties);

  public List<Project> GetList(Expression<Func<Project, bool>> filter = null);
  public Task<List<Project>> GetListAsync<T>(Expression<Func<Project, bool>> filter = null);

  public List<Project> GetList(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties);

  public Task<List<Project>> GetListAsync(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties);

  public bool CheckAny(Expression<Func<Project, bool>> filter = null);
  public Task<bool> CheckAnyAsync(Expression<Func<Project, bool>> filter = null);
}
