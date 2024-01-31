using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberFavCourse
{
    public int fMFavCId { get; set; }

    public int fMemberId { get; set; }

    public bool fCourseType { get; set; }

    public int fCourseId { get; set; }

    public virtual tMember fMember { get; set; } = null!;
}
