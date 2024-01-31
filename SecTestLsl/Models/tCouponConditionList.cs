using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCouponConditionList
{
    public int fCouponConditionId { get; set; }

    public string fCouponConditionName { get; set; } = null!;

    public int? fTeacherId { get; set; }

    public bool? fCourseType { get; set; }

    public int? fField_Id { get; set; }

    public int? fSubjectId { get; set; }

    public bool fNewRegistrantOrNot { get; set; }

    public short? fBirthdayOffer { get; set; }

    public virtual tCourseField? fField { get; set; }

    public virtual tCourseSubject? fSubject { get; set; }

    public virtual tTeacher? fTeacher { get; set; }

    public virtual ICollection<tCoupon> tCoupons { get; set; } = new List<tCoupon>();
}
