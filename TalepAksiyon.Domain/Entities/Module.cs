using System.ComponentModel;

namespace TalepAksiyon.Domain.Entities;

public class Module:BaseEntity
{
  [DisplayName("Modül Adı")]
  public string Name { get; set; }

  [DisplayName("Modül Açıklaması")]
  public string? Description { get; set; }
  public string? Key { get; set; }
  public int ProjectID { get; set; }
  public Project Project { get; set; }

}
