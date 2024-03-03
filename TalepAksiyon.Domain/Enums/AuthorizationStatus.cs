using System.ComponentModel.DataAnnotations;

namespace TalepAksiyon.Domain.Enums;

public enum AuthorizationStatus
{
  [Display(Name = "Admin")]
  Admin = 0,
  [Display(Name = "Ekip Lideri")]
  TeamsLeader = 1,
  [Display(Name = "Developer")]
  Developer = 2
}
