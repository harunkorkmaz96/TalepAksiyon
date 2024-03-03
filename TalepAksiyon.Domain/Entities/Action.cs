﻿using System.ComponentModel;
using TalepAksiyon.Domain.Enums;

namespace TalepAksiyon.Domain.Entities;

public class Action : BaseEntity
{
  [DisplayName("Aksiyon Konusu")]
  public string ActionDescription { get; set; }

  [DisplayName("Sorumlu")]
  public int ResponsibleID { get; set; }
  public User Responsible { get; set; }

  [DisplayName("Açılma Tarihi")]
  public DateTime OpeningDate { get; set; }
  
  [DisplayName("Son Tarih")]
  public DateTime EndDate { get; set; }

  public string? Description { get; set; }

  [DisplayName("Durum")]
  public ActionStatus ActionStatus { get; set; }
  public RequestStatus RequestStatus { get; set; }
  public ActionPriorityStatus ActionPriorityStatus { get; set; }
  public int RequestID { get; set; }
  public Request Request { get; set; }
}
