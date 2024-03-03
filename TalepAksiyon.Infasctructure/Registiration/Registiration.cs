using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TalepAksiyon.Persistance.TalepAksiyonContextes;

namespace TalepAksiyon.Infasctructure.Registiration;

public static class Registiration
{
  public static void AddDataBase(this IServiceCollection service, string connectionString)
  {
    service.AddDbContext<TalepAksiyonContext>(options =>
    {
      options.UseSqlServer(connectionString);
    });
  }
}
