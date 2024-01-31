using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumMod
{
    public int fForumModId { get; set; }

    public int fForumMemberId { get; set; }

    public int fForumBoardId { get; set; }

    public virtual tForumBoard fForumBoard { get; set; } = null!;

    public virtual tForumMember fForumMember { get; set; } = null!;
}
