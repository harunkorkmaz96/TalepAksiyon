using System.ComponentModel.DataAnnotations;

namespace TalepAksiyon.Domain.Enums;

public enum DatabaseChangeStatus
{
  [Display(Name = "Evet")]
  yes = 0,

  [Display(Name = "Hayır")]
  no = 1,
}
