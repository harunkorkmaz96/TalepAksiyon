using System.ComponentModel;

namespace TalepAksiyon.Domain.Entities;

public class Project : BaseEntity
{
  public Project()
  {
    ProjectGuid = Guid.NewGuid();
  }
  [DisplayName("Proje Adı")]
  public string ProjectName { get; set; }

  [DisplayName("Proje Açıklaması")]
  public string? ProjectDescription { get; set; }
  public Guid ProjectGuid { get; set; }

  public ICollection<Version> Versions { get; set; }
  public ICollection<Module> Modules { get; set; }
  public ICollection<ProjectNote> ProjectNotes { get; set; }
  public ICollection<Request> Requests { get; set; }
}
