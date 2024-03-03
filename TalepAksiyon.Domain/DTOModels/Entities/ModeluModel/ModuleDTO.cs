using System.ComponentModel;

namespace TalepAksiyon.Domain.DTOModels.Entities.ModeluModel;

public class ModuleDTO
{
  [DisplayName("Modül Adı")]
  public string Name { get; set; }

  [DisplayName("Modül Açıklaması")]
  public string Description { get; set; }
  public string Key { get; set; }
}
