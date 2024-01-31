using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCoursework
{
    public int fCourseworkId { get; set; }

    public int fOrderDetail_Id { get; set; }

    public string fName { get; set; } = null!;

    public string? fDescrpition { get; set; }

    public DateTime fLastModifyTime { get; set; }

    public int? fMemberId { get; set; }

    public string? fShareAudience { get; set; }

    public string? fComment { get; set; }

    public DateTime? fCommentTime { get; set; }

    public virtual tOrderDetail fOrderDetail { get; set; } = null!;

    public virtual ICollection<tCourseworkFile> tCourseworkFiles { get; set; } = new List<tCourseworkFile>();
}
