using Microsoft.AspNetCore.Mvc;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Application.Services.SecurityService;
using TalepAksiyon.Domain.DTOModels.Entities.LoginModel;

namespace TalepAksiyon.WebApp.Controllers
{
  public class SecurityController : Controller
  {
    private readonly ISecurityRepository _securityRepository;
    private readonly ISessionService _sessionService;
    public SecurityController(ISecurityRepository securityRepository, ISessionService sessionService)
    {
      _securityRepository = securityRepository;
      _sessionService = sessionService;
    }

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginDTO model)
    {
      var user = await _securityRepository.Login(model.UserName, model.Password);
      
      if (user != null)
      {
        _sessionService.SetUser(user);
        return Redirect("/Home/Index");
      }
      else
      {
        ModelState.AddModelError("All", "Kullanıcı Adı veya Şifre Hatalı");
        return View(model);
      }
    }
    public IActionResult Logout()
    {
      _sessionService.CleanSession();
      return RedirectToAction(nameof(Login));
    }
  }
}
