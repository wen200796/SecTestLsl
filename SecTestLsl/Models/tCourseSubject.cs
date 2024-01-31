using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCourseSubject
{
    public int fField_Id { get; set; }

    public int fSubjectId { get; set; }

    public string fSubjectName { get; set; } = null!;

    public string fSubjectCode { get; set; } = null!;

    public virtual tCourseField fField { get; set; } = null!;

    public virtual ICollection<tCouponConditionList> tCouponConditionLists { get; set; } = new List<tCouponConditionList>();

    public virtual tForumBoard? tForumBoard { get; set; }

    public virtual ICollection<tLessonCourse> tLessonCourses { get; set; } = new List<tLessonCourse>();

    public virtual ICollection<tTeacherSubject> tTeacherSubjects { get; set; } = new List<tTeacherSubject>();

    public virtual ICollection<tVenueSubject> tVenueSubjects { get; set; } = new List<tVenueSubject>();

    public virtual ICollection<tVideoCourse> tVideoCourses { get; set; } = new List<tVideoCourse>();
}
