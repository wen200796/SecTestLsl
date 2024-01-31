using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tLessonCourseEvaluation
{
    public int fLessonEval_Id { get; set; }

    public int fMemberId { get; set; }

    public int fLessonCourseId { get; set; }

    public int fScore { get; set; }

    public string? fComment { get; set; }

    public DateTime fCommentDate { get; set; }

    public DateTime? fCommentUpdateDate { get; set; }

    public bool fDisplayStatus { get; set; }

    public virtual tLessonCourse fLessonCourse { get; set; } = null!;

    public virtual tMember fMember { get; set; } = null!;
}
