using System.Linq.Expressions;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public interface IRequestRepository: IRepository
{
  public Request GetById(int id);
  public Task<Request> GetByIdAsync(int id);

  public Request Get(Expression<Func<Request, bool>> filter = null);
  public Task<Request> GetAsync(Expression<Func<Request, bool>> filter = null);

  public  Request Get(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties);

  public Task<Request> GetAsync(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties);

  public List<Request> GetList(Expression<Func<Request, bool>> filter = null);
  public Task<List<Request>> GetListAsync<T>(Expression<Func<Request, bool>> filter = null);

  public List<Request> GetList(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties);

  public Task<List<Request>> GetListAsync(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties);

  public bool CheckAny(Expression<Func<Request, bool>> filter = null);
  public Task<bool> CheckAnyAsync(Expression<Func<Request, bool>> filter = null);
}
