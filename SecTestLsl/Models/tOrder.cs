using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tOrder
{
    public int fOrderId { get; set; }

    public int fMemberId { get; set; }

    public DateTime fOrderTime { get; set; }

    public int? fCouponId { get; set; }

    public string fPaymentMethod { get; set; } = null!;

    public DateTime? fPaymentDeadline { get; set; }

    public bool? fPayOrNot { get; set; }

    public string? fPaymentInformation { get; set; }

    public DateTime? fAccountingTime { get; set; }

    public virtual tCoupon? fCoupon { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual ICollection<tOrderDetail> tOrderDetails { get; set; } = new List<tOrderDetail>();
}
