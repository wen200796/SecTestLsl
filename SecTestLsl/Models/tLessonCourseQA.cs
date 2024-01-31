using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tLessonCourseQA
{
    public int fLessonQAId { get; set; }

    public int fLessonCourseId { get; set; }

    public int fMemberId { get; set; }

    public string fPurpose { get; set; } = null!;

    public string? fQuestion { get; set; }

    public DateTime fQuestionDate { get; set; }

    public string? fAnswer { get; set; }

    public DateTime? fAnswerDate { get; set; }

    public bool fAnswerCondition { get; set; }

    public bool fDisplayStatus { get; set; }

    public virtual tLessonCourse fLessonCourse { get; set; } = null!;

    public virtual tMember fMember { get; set; } = null!;
}
