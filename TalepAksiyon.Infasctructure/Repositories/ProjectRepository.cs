using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Persistance.TalepAksiyonContextes;

namespace TalepAksiyon.Infasctructure.Repositories;

public class ProjectRepository: Repository, IProjectRepository
{
  private readonly TalepAksiyonContext _context;
  private readonly DbSet<Project> _dbSet;
  public ProjectRepository(TalepAksiyonContext context):base(context)
  {
    _context = context;
    _dbSet=_context.Set<Project>();
  }
  public bool CheckAny(Expression<Func<Project, bool>> filter = null)
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
  public async Task<bool> CheckAnyAsync(Expression<Func<Project, bool>> filter = null)
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
public Project Get(Expression<Func<Project, bool>> filter = null)
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
  public Project Get(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties)
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
  public async Task<Project> GetAsync(Expression<Func<Project, bool>> filter = null)
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
  public async Task<Project> GetAsync(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties)
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
  public Project GetById(int id)
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
  public async Task<Project> GetByIdAsync(int id)
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
  public List<Project> GetList(Expression<Func<Project, bool>> filter = null)
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
  public List<Project> GetList(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties)
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
  public async Task<List<Project>> GetListAsync<T>(Expression<Func<Project, bool>> filter = null)
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
  public async Task<List<Project>> GetListAsync(Expression<Func<Project, bool>> filter = null, params Expression<Func<Project, object>>[] includeProperties)
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
