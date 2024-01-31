using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tShoppingCart
{
    public int fShoppingCartId { get; set; }

    public int fMemberId { get; set; }

    public bool fCourseType { get; set; }

    public int fCourseId { get; set; }

    public virtual tMember fMember { get; set; } = null!;
}
