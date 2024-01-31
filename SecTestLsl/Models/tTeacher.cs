using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tTeacher
{
    public int fMemberId { get; set; }

    public int fTeacherId { get; set; }

    public string fTeacherName { get; set; } = null!;

    public DateTime fJoinDatetime { get; set; }

    public byte[]? fTeacherProfilePic { get; set; }

    public string? fIntroduction { get; set; }

    public string? fNote { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual ICollection<tCouponConditionList> tCouponConditionLists { get; set; } = new List<tCouponConditionList>();

    public virtual ICollection<tLessonCourse> tLessonCourses { get; set; } = new List<tLessonCourse>();

    public virtual ICollection<tMemberFavTeacher> tMemberFavTeachers { get; set; } = new List<tMemberFavTeacher>();

    public virtual ICollection<tTeacherEventLog> tTeacherEventLogs { get; set; } = new List<tTeacherEventLog>();

    public virtual ICollection<tTeacherImage> tTeacherImages { get; set; } = new List<tTeacherImage>();

    public virtual ICollection<tTeacherSubject> tTeacherSubjects { get; set; } = new List<tTeacherSubject>();

    public virtual ICollection<tVenueTimeList> tVenueTimeLists { get; set; } = new List<tVenueTimeList>();

    public virtual ICollection<tVideoCourse> tVideoCourses { get; set; } = new List<tVideoCourse>();
}
