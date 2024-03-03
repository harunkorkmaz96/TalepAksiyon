using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Domain.DTOModels.Entities.ActionModels;
using TalepAksiyon.Domain.DTOModels.ResponsibleHelperModels;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Domain.Enums;
using TalepAksiyon.Persistance.TalepAksiyonContextes;
using Action = TalepAksiyon.Domain.Entities.Action;
using Version = TalepAksiyon.Domain.Entities.Version;

namespace TalepAksiyon.Infasctructure.Repositories;

public class RequestRepository : Repository, IRequestRepository
{
  private readonly TalepAksiyonContext _context;
  private readonly DbSet<Request> _dbSet;
  public RequestRepository(TalepAksiyonContext context): base(context)
  {
    _context = context;
    _dbSet = _context.Set<Request>();
  }
  public bool CheckAny(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      return filter == null ? _dbSet.Any() : _dbSet.Any(filter);

    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<bool> CheckAnyAsync(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      return filter == null ?
        await _dbSet.AnyAsync() :
        await _dbSet.AnyAsync(filter);

    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public Request Get(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      var data = filter == null ?
      _dbSet.FirstOrDefault() :
      _dbSet.FirstOrDefault(filter);
      return data;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public Request Get(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties)
  {
    try
    {
      var query = _dbSet.AsQueryable();
      if (includeProperties != null)
        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

      var data = filter == null ?
        query.FirstOrDefault() :
        query.FirstOrDefault(filter);
      return data;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<Request> GetAsync(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      var data = filter == null ?
        await _dbSet.FirstOrDefaultAsync() :
        await _dbSet.FirstOrDefaultAsync(filter);
      return data;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<Request> GetAsync(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties)
  {
    try
    {
      var query = _dbSet.AsQueryable();
      if (includeProperties != null)
        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

      var data = filter == null ?
        await query.FirstOrDefaultAsync() :
        await query.FirstOrDefaultAsync(filter);
      return data;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public Request GetById(int id)
  {
    try
    {
      var data = _dbSet.Find(id);
      return data;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<Request> GetByIdAsync(int id)
  {
    try
    {
      var data = await _dbSet.FindAsync(id);
      return data;
    }
    catch (Exception ex)
    {

      throw new Exception(ex.Message);
    }
  }
  public List<Request> GetList(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      var list = filter == null ?
        _dbSet.ToList() :
        _dbSet.Where(filter).ToList();
      return list;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public List<Request> GetList(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties)
  {
    try
    {
      var query = _dbSet.AsQueryable();

      if (includeProperties != null)
        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

      var dataList = filter == null ?
        query.ToList() :
        query.Where(filter).ToList();
      return dataList.ToList();
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<List<Request>> GetListAsync<T>(Expression<Func<Request, bool>> filter = null)
  {
    try
    {
      var list = filter == null ?
       await _dbSet.ToListAsync() :
       await _dbSet.Where(filter).ToListAsync();
      return list;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<List<Request>> GetListAsync(Expression<Func<Request, bool>> filter = null, params Expression<Func<Request, object>>[] includeProperties)
  {
    try
    {
      var query = _dbSet.AsQueryable();
      if (includeProperties != null)
        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

      var list = filter == null ?
       await query.ToListAsync() :
       await query.Where(filter).ToListAsync();
      return list;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
}
