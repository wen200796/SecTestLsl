using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tOrderDetail
{
    public int fOrderId { get; set; }

    public int fOrderDetail_Id { get; set; }

    public bool fCourseType { get; set; }

    public int fCourseId { get; set; }

    public decimal fCoursePrice { get; set; }

    public decimal fDiscount { get; set; }

    public bool fOrderValidOrNot { get; set; }

    public string? fModificationDescription { get; set; }

    public virtual tOrder fOrder { get; set; } = null!;

    public virtual ICollection<tCoursework> tCourseworks { get; set; } = new List<tCoursework>();
}
