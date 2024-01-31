using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumMemberFloMember
{
    public int fForumMemberFloMemberId { get; set; }

    public int fForumMemberId { get; set; }

    public int fForumIsFloMemberId { get; set; }

    public virtual tForumMember fForumIsFloMember { get; set; } = null!;

    public virtual tForumMember fForumMember { get; set; } = null!;
}
