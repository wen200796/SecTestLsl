using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberFavTeacher
{
    public int fMFavTId { get; set; }

    public int fMemberId { get; set; }

    public int fTeacherId { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual tTeacher fTeacher { get; set; } = null!;
}
