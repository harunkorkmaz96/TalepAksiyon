using System.ComponentModel.DataAnnotations;

namespace TalepAksiyon.Domain.Enums;

public enum CategoryStatus
{
  [Display(Name = "Sınıflandırılmamış")]
  Sınıflandırılmamış = 0,
  [Display(Name = "Yeni Fonksiyon")]
  YeniFonksiyon = 1,
  [Display(Name = "Hata Giderme")]
  HataGiderme = 2,
  [Display(Name = "Veri Düzetlme")]
  VeriDüzeltme = 3,
  [Display(Name = "Uyunmluluk")]
  Uyumluluk = 4
}
