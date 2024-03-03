using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Application.Services.EmailService;
using TalepAksiyon.Application.Services.SecurityService;
using TalepAksiyon.Infasctructure.Services.EmailServices;
using TalepAksiyon.Infasctructure.Services.SecurityServices;

namespace TalepAksiyon.Infasctructure.Repositories
{
  public static class ServiceCollectionExtensions
  {
    public static void MyRepository(this IServiceCollection services)
    {
      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
      //services.AddTransient<IUnitOfWork, UnitOfWork>();
      services.AddTransient<ISessionService, SessionService>();
      services.AddTransient<IEmailService, EmailService>();
      services.AddTransient<ISecurityRepository, SecurityRepository>();
    }
  }
}
