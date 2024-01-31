using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumMemberFloTag
{
    public int fForumMemberFloTagId { get; set; }

    public int fForumMemberId { get; set; }

    public int fForumTagId { get; set; }

    public virtual tForumMember fForumMember { get; set; } = null!;

    public virtual tForumTag fForumTag { get; set; } = null!;
}
