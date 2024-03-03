using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Persistance.TalepAksiyonContextes;
namespace TalepAksiyon.Infasctructure.Repositories;

public class Repository : IRepository 
{
  private readonly TalepAksiyonContext _context;

  public Repository(TalepAksiyonContext context)
  {
    _context = context;
  }
  public T Add<T>(T entity) 
  {
    try
    {
      _context.Add(entity);
      _context.SaveChanges();
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
    return entity;
  }
  public async Task<T> AddAsync<T>(T entity) 
  {
    try
    {
      await _context.AddAsync(entity);
      await _context.SaveChangesAsync();
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);

    }
    return entity;
  }
  public T Delete<T>(T entity) 
  {
    try
    {
      _context.Remove(entity);
      _context.SaveChanges();
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
    return entity;
  }
  public async Task<T> DeleteAsync<T>(T entity) 
  {
    try
    {
      _context.Remove(entity);
      await _context.SaveChangesAsync();
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
    return entity;
  }
  public T Update<T>(T entity) 
  {
    try
    {
      _context.Update(entity);
      _context.SaveChanges();
      return entity;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
  public async Task<T> UpdateAsync<T>(T entity) 
  {
    try
    {
      _context.Update(entity);
      await _context.SaveChangesAsync();
      return entity;
    }
    catch (Exception ex)
    {
      throw new Exception(ex.Message);
    }
  }
}
