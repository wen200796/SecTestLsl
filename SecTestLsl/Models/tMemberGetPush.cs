using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberGetPush
{
    public int fMemberGetPushId { get; set; }

    public int fMemberId { get; set; }

    public int fPushMessageId { get; set; }

    public bool? fPushRead { get; set; }

    public DateTime fPushCreatedTime { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual tPushMessage fPushMessage { get; set; } = null!;
}
