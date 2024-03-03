namespace TalepAksiyon.Application.Repositories;

public interface IVersionRepository
{
  public Task<IQueryable<Domain.Entities.Version>> GetList();
  public Task<string> AddVersion(Domain.Entities.Version model);
  public Task<string> UpdateVersion(Domain.Entities.Version model);
  public string DeleteVersion(int ID);
}
