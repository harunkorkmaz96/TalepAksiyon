﻿namespace TalepAksiyon.Application.Repositories;

public interface IHomeRepository: IRepository
{
  public Task<IQueryable<Domain.Entities.Task>> GetTaskHome();
  public Task<IQueryable<Domain.Entities.Action>> GetActionHome();
}
