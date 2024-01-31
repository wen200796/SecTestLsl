using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tServiceForm
{
    public int fServiceId { get; set; }

    public int fMemberId { get; set; }

    public int? fEmployeeId { get; set; }

    public int? fServiceParentId { get; set; }

    public DateTime fServiceCreatedTime { get; set; }

    public string? fServiceChannel { get; set; }

    public string? fServiceType { get; set; }

    public string? fServiceTag { get; set; }

    public string? fServiceContent { get; set; }

    public DateTime? fServiceClosedTime { get; set; }

    public string? fServiceStatus { get; set; }

    public int? fServiceStep { get; set; }

    public string fServiceFormType { get; set; } = null!;

    public virtual tAdmin? fEmployee { get; set; }

    public virtual tMember fMember { get; set; } = null!;
}
