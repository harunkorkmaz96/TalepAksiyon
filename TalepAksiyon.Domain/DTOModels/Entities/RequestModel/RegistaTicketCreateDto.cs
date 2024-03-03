using System.ComponentModel;

namespace TalepAksiyon.Domain.DTOModels.Entities.RequestModel;

public class RegistaTicketCreateDto
{
  public int ID { get; set; }

  [DisplayName("Bildirim Türü")]
  public string TicketType { get; set; }

  [DisplayName("Bildirim Başlığı")]
  public string TicketTitle { get; set; }

  [DisplayName("Bildirim Açıklama")]
  public string TicketContent { get; set; }


  [DisplayName("Görüntü")]
  public string? Image { get; set; }

  [DisplayName("Sayfa Yolu")]
  public string PageUrl { get; set; }
}
