﻿using Microsoft.AspNetCore.Mvc.Rendering;
using TalepAksiyon.Domain.Enums;

namespace TalepAksiyon.Domain.DTOModels.Entities.ActionModels;

public class ActionDTO
{
  public int ID { get; set; }
  public string ActionDescription { get; set; }
  public int ResponsibleID { get; set; }
  public int RequestID { get; set; }
  public DateTime OpeningDate { get; set; }
  public DateTime EndDate { get; set; }
  public DateTime? CreatedOn { get; set; }
  public ActionStatus ActionStatus { get; set; }
  public RequestStatus RequestStatus { get; set; }
  public ActionPriorityStatus ActionPriorityStatus { get; set; }
  public string Description { get; set; }
  public string LastModifiedBy { get; set; }
  public string Color { get; set; }

  public List<SelectListItem> ResponsiblehelperModelList { get; set; }
}
