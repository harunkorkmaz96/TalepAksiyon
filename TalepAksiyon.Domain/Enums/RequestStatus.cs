using System.ComponentModel.DataAnnotations;

namespace TalepAksiyon.Domain.Enums;

public enum RequestStatus
{
  [Display(Name = "Açık")]
  Open = 0,

  [Display(Name = "Başladı")]
  Start = 1,

  [Display(Name = "Kapandı")]
  Closed = 2,

  [Display(Name = "İptal/Reddedildi")]
  Cancel = 3,
}
