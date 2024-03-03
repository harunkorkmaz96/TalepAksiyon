using System.Linq.Expressions;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Repositories;

public interface IRepository
   
{
  public T Add<T>(T entity);
  public Task<T> AddAsync<T>(T entity);

  public T Update<T>(T entity);
  public Task<T> UpdateAsync<T>(T entity);

  public T Delete<T>(T entity);
  public Task<T> DeleteAsync<T>(T entity);

}
