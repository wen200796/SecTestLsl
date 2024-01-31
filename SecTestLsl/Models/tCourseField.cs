using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCourseField
{
    public int fField_Id { get; set; }

    public string fFieldName { get; set; } = null!;

    public string fFieldCode { get; set; } = null!;

    public virtual ICollection<tCouponConditionList> tCouponConditionLists { get; set; } = new List<tCouponConditionList>();

    public virtual ICollection<tCourseSubject> tCourseSubjects { get; set; } = new List<tCourseSubject>();

    public virtual ICollection<tMemberWishField> tMemberWishFields { get; set; } = new List<tMemberWishField>();
}
