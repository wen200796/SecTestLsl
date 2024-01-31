using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberLoginLog
{
    public int fLoginLogId { get; set; }

    public int fMemberId { get; set; }

    public DateTime fLoginDateTime { get; set; }

    public string? fLoginIP { get; set; }

    public string? fLoginDevice { get; set; }

    public virtual tMember fMember { get; set; } = null!;
}
