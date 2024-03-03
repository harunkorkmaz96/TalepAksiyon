using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TalepAksiyon.Application.Services.SecurityService;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Domain.Enums;
using Action = TalepAksiyon.Domain.Entities.Action;
using Task = TalepAksiyon.Domain.Entities.Task;
using Version = TalepAksiyon.Domain.Entities.Version;

namespace TalepAksiyon.Persistance.TalepAksiyonContextes;

public class TalepAksiyonContext : DbContext
{
  protected IHttpContextAccessor _httpContextAccessor;
  private readonly ISessionService _sessionService;

  public TalepAksiyonContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor) : base(options)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public override int SaveChanges()
  {
    SetBaseObjectValues();
    return base.SaveChanges();
  }
  public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
  {
    SetBaseObjectValues();
    return base.SaveChangesAsync(cancellationToken);
  }
  private void SetBaseObjectValues()
  {
    var user = _sessionService.GetUser();
    var userName = user != null ? user.FullName : "-";

    ChangeTracker.DetectChanges();

    var entries = ChangeTracker.Entries();

    foreach (var entry in entries)
    {
      if (entry.Entity is BaseEntity trackable)
      {
        var now = DateTime.Now;

        switch (entry.State)
        {
          case EntityState.Modified:
            trackable.LastModifiedOn = now;
            trackable.LastModifiedBy = userName;
            break;

          case EntityState.Added:
            trackable.LastModifiedOn = now;
            trackable.CreatedOn = now;
            trackable.CreatedBy = userName;
            trackable.LastModifiedBy = userName;
            trackable.Status = Status.Active;
            trackable.ObjectStatus = ObjectStatus.NonDeleted;
            break;
        }
      }
    }
  }






  public DbSet<Customer> Customers { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Project> Projects { get; set; }
  public DbSet<Task> Tasks { get; set; }
  public DbSet<Action> Actions { get; set; }
  public DbSet<ProjectNote> ProjectNotes { get; set; }
  public DbSet<Request> Requests { get; set; }
  public DbSet<Module> Modules { get; set; }
  public DbSet<Version> Versions { get; set; }
}
