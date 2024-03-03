using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TalepAksiyon.Application.Repositories;
using TalepAksiyon.Domain.Entities;
using TalepAksiyon.Domain.Enums;



namespace TalepAksiyon.WebApp.Controllers;

public class RequestController : Controller
{
  private readonly IUnitOfWork _unitOfWork;

  public RequestController(IUnitOfWork unitOfWork)
  {
    _unitOfWork = unitOfWork;
  }

  public IActionResult Detail()
  {
    return View();
  }
  [HttpGet]
  public async Task<IActionResult> GetActions(DataSourceLoadOptions loadOptions)
  {
    var result = await _unitOfWork.RequestRepository.GetListAsync(t => t.ObjectStatus == ObjectStatus.NonDeleted && t.Status == Status.Active);
    return Ok(DataSourceLoader.Load(result, loadOptions));
  }
  [HttpPost]
  public async Task<IActionResult> AddAction(string values)
  {
    var newObject = new Request();
    JsonConvert.PopulateObject(values, newObject);

    if (!TryValidateModel(newObject))
      return BadRequest("İŞLEM BAŞARISIZ");
    var result = await _unitOfWork.RequestRepository.AddAsync(newObject);
    return Ok(result);
  }
  [HttpPut]
  public async Task<IActionResult> UpdateAction(int key, string values)
  {
    var result = await _unitOfWork.RequestRepository.UpdateAsync(key);
    JsonConvert.PopulateObject(values, result);

    if (!TryValidateModel(result))
      return BadRequest("İŞLEM BAŞARISIZ");

    return Ok(result);
  }
  [HttpDelete]
  public async Task<IActionResult> DeleteAction(int key)
  {
    var result = await _unitOfWork.RequestRepository.DeleteAsync(key);

    if (!TryValidateModel(result))
      return BadRequest("İŞLEM BAŞARISIZ");

    return Ok(result);
  }
}

