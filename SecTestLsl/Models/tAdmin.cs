using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tAdmin
{
    public int fEmployeeId { get; set; }

    public string? fEmployeeName { get; set; }

    public string? fEmployeeEmail { get; set; }

    public string? fPassword { get; set; }

    public string? fAdminRole { get; set; }

    public DateTime? fAdminJoinDate { get; set; }

    public bool? fAccountStatus { get; set; }

    public string? fNote { get; set; }

    public virtual ICollection<tPushMessage> tPushMessages { get; set; } = new List<tPushMessage>();

    public virtual ICollection<tServiceForm> tServiceForms { get; set; } = new List<tServiceForm>();
}
