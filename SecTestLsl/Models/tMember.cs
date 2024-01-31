using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMember
{
    public int fMemberId { get; set; }

    public DateTime fRegisterDatetime { get; set; }

    public string fRealName { get; set; } = null!;

    public string fShowName { get; set; } = null!;

    public string fEmail { get; set; } = null!;

    public string? fPhone { get; set; }

    public string fPassword { get; set; } = null!;

    public bool? fEmailVerification { get; set; }

    public byte[]? fMemberProfilePic { get; set; }

    public bool fGetCampaignInfo { get; set; }

    public bool fQualifiedTeacher { get; set; }

    public bool fVideoFunc { get; set; }

    public bool fBookLessonFunc { get; set; }

    public bool? fGender { get; set; }

    public DateTime? fBirthDate { get; set; }

    public string? fJob { get; set; }

    public string? fEducation { get; set; }

    public string? fNote { get; set; }

    public virtual tForumMember? tForumMember { get; set; }

    public virtual ICollection<tLessonCourseEvaluation> tLessonCourseEvaluations { get; set; } = new List<tLessonCourseEvaluation>();

    public virtual ICollection<tLessonCourseQA> tLessonCourseQAs { get; set; } = new List<tLessonCourseQA>();

    public virtual ICollection<tMemberCitiesList> tMemberCitiesLists { get; set; } = new List<tMemberCitiesList>();

    public virtual ICollection<tMemberFavCourse> tMemberFavCourses { get; set; } = new List<tMemberFavCourse>();

    public virtual ICollection<tMemberFavTeacher> tMemberFavTeachers { get; set; } = new List<tMemberFavTeacher>();

    public virtual ICollection<tMemberGetPush> tMemberGetPushes { get; set; } = new List<tMemberGetPush>();

    public virtual ICollection<tMemberLoginLog> tMemberLoginLogs { get; set; } = new List<tMemberLoginLog>();

    public virtual ICollection<tMemberWishField> tMemberWishFields { get; set; } = new List<tMemberWishField>();

    public virtual ICollection<tOrder> tOrders { get; set; } = new List<tOrder>();

    public virtual ICollection<tServiceForm> tServiceForms { get; set; } = new List<tServiceForm>();

    public virtual ICollection<tShoppingCart> tShoppingCarts { get; set; } = new List<tShoppingCart>();

    public virtual ICollection<tTeacherApplyLog> tTeacherApplyLogs { get; set; } = new List<tTeacherApplyLog>();

    public virtual ICollection<tTeacher> tTeachers { get; set; } = new List<tTeacher>();

    public virtual ICollection<tVideoCourseEvaluation> tVideoCourseEvaluations { get; set; } = new List<tVideoCourseEvaluation>();

    public virtual ICollection<tVideoCourseQA> tVideoCourseQAs { get; set; } = new List<tVideoCourseQA>();
}
