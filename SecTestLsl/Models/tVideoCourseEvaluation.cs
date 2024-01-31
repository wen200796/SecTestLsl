using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVideoCourseEvaluation
{
    public int fVideoCourseEval_Id { get; set; }

    public int fMemberId { get; set; }

    public int fVideoCourseId { get; set; }

    public int fScore { get; set; }

    public string? fComment { get; set; }

    public DateTime fCommentDate { get; set; }

    public DateTime? fCommentUpdateDate { get; set; }

    public bool fDisplayStatus { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual tVideoCourse fVideoCourse { get; set; } = null!;
}
