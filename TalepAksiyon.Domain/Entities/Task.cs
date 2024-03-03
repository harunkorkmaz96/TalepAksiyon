using System.ComponentModel;
using TalepAksiyon.Domain.Enums;
using TaskStatus = TalepAksiyon.Domain.Enums.TaskStatus;


namespace TalepAksiyon.Domain.Entities;

public class Task : BaseEntity
{
  [DisplayName("Planlanan Başlangıç Tarihi")]
  public DateTime PlanedStart { get; set; }

  [DisplayName("Planlanan Bitiş Tarihi")]
  public DateTime PlanedEnd { get; set; }

  [DisplayName("Resim/Ekran Görüntüsü")]
  public string? Image { get; set; }

  [DisplayName("Konu/Başlık")]
  public string Title { get; set; }

  [DisplayName("Açıklama")]
  public string Description { get; set; }

  [DisplayName("Sorumlu")]
  public int ResponsibleID { get; set; }

  [DisplayName("Durum")]
  public TaskStatus TaskStatus { get; set; }

  [DisplayName("Öncelik")]
  public PriorityStatus PriorityStatus { get; set; }
  public int CustomerID { get; set; }
  public Customer Customer { get; set; }
  public int RequestID { get; set; }
  public Request Request { get; set; }
}
