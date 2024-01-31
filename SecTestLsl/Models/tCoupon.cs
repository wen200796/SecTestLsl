using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCoupon
{
    public int fCouponId { get; set; }

    public string fDiscountCode { get; set; } = null!;

    public bool fCouponValidOrNot { get; set; }

    public decimal fCouponDiscount { get; set; }

    public DateTime fCouponCreatedDate { get; set; }

    public DateTime fCouponStartDate { get; set; }

    public DateTime fCouponEndDate { get; set; }

    public int? fCouponConditionId { get; set; }

    public virtual tCouponConditionList? fCouponCondition { get; set; }

    public virtual ICollection<tOrder> tOrders { get; set; } = new List<tOrder>();
}
