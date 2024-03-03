using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Application.Services.EmailService;
using TalepAksiyon.Domain.DTOModels.EmailModels;
using TalepAksiyon.Domain.DTOModels.SecurityModels;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Persistance.TalepAksiyonContextes;

namespace TalepAksiyon.Infasctructure.Services.EmailServices;

public class EmailService : IEmailService
{
  private readonly IHttpContextAccessor _httpContextAccessor;

  private readonly TalepAksiyonContext context;

  private readonly SessionModel session;

  private readonly IUnitOfWork uow;
  public EmailService(IHttpContextAccessor httpContextAccessor)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public bool Send(EmailSendDto email, Customer UserWhitCustomer)
  {
    try
    {
      MailMessage mm = new MailMessage();
      mm.From = new MailAddress(UserWhitCustomer.ContactEmail, "Bildirim Mail");
      mm.To.Add(email.To);
      if (email.CCes != null)
      {
        foreach (var item in email.CCes)
        {
          mm.CC.Add(item);
        }
      }
      mm.Subject = email.Subject;
      if (!string.IsNullOrEmpty(email.AttachmentUrl))
      {
        Attachment data = new Attachment(email.AttachmentUrl, MediaTypeNames.Application.Octet);
        mm.Attachments.Add(data);
      }

      mm.IsBodyHtml = true;
      mm.Body = email.Body;
      SmtpClient smtp = new SmtpClient(UserWhitCustomer.ContactEmail);
      smtp.Host = UserWhitCustomer.EmailHost;
      smtp.Port = Convert.ToInt32(UserWhitCustomer.EmailPort);
      smtp.EnableSsl = UserWhitCustomer.EnableSsl;
      NetworkCredential nc = new NetworkCredential(UserWhitCustomer.ContactEmail, UserWhitCustomer.EmailPassword);//Emaili Gönderen Hesap

      smtp.Credentials = nc;
      System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
      System.Security.Cryptography.X509Certificates.X509Certificate certificate,
      System.Security.Cryptography.X509Certificates.X509Chain chain,
      System.Net.Security.SslPolicyErrors sslPolicyErrors)
      {
        return true;
      };

      smtp.Send(mm);
      return true;
    }
    catch (Exception e)
    {
      throw e;
    }
  }
}
