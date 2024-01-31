using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tTeacherApplyLog
{
    public int fApplyLogId { get; set; }

    public DateTime fApplyDatetime { get; set; }

    public int fMemberId { get; set; }

    public string fRealName { get; set; } = null!;

    public string fContactInfo { get; set; } = null!;

    public string? fIntroduction { get; set; }

    public string? fReason { get; set; }

    public string? fPdfLink { get; set; }

    public string? fTeacherPlanLink { get; set; }

    public string? fProgressStatus { get; set; }

    public bool? fReviewResult { get; set; }

    public DateTime? fReviewDatetime { get; set; }

    public int? fEmployeeId { get; set; }

    public string? fNote { get; set; }

    public virtual tMember fMember { get; set; } = null!;
}
