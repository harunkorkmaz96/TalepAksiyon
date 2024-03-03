using TalepAksiyon.Domain.DTOModels.EmailModels;
using TalepAksiyon.Domain.Entities;

namespace TalepAksiyon.Application.Services.EmailService;

public interface IEmailService
{
  bool Send(EmailSendDto email, Customer UserWhitCustomer);
}
