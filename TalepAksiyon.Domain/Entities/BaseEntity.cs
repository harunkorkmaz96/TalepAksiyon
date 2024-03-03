using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TalepAksiyon.Domain.Enums;

namespace TalepAksiyon.Domain.Entities;

public class BaseEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int ID { get; set; }

  [DisplayName("Oluşturulma Tarihi")]
  public DateTime? CreatedOn { get; set; }

  [DisplayName("Güncellenme Tarihi")]
  public DateTime? LastModifiedOn { get; set; }

  [DisplayName("Oluşturan Kullanıcı")]
  public string CreatedBy { get; set; }

  [DisplayName("Güncelleyen Kullanıcı")]
  public string LastModifiedBy { get; set; }

  [DisplayName("Silindi Bilgisi")]
  [DefaultValue(0)]
  public ObjectStatus ObjectStatus { get; set; }

  [DisplayName("Durum")]
  [DefaultValue(1)]
  public Status Status { get; set; }
}
