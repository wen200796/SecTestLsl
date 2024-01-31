using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberWishField
{
    public int fMWishFieldsId { get; set; }

    public int fMemberId { get; set; }

    public int fField_Id { get; set; }

    public virtual tCourseField fField { get; set; } = null!;

    public virtual tMember fMember { get; set; } = null!;
}
