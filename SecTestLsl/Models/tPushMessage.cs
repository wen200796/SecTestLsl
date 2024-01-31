using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tPushMessage
{
    public int fPushMessageId { get; set; }

    public string fPushType { get; set; } = null!;

    public int fPushLayoutId { get; set; }

    public string fPushMethod { get; set; } = null!;

    public DateTime fPushStartDate { get; set; }

    public DateTime fPushEndDate { get; set; }

    public string fPushContent { get; set; } = null!;

    public byte[]? fPushImagePath { get; set; }

    public DateTime fPushCreatedTime { get; set; }

    public DateTime fPushLastUpdatedTime { get; set; }

    public int fEmployeeId { get; set; }

    public virtual tAdmin fEmployee { get; set; } = null!;

    public virtual tPushLayout fPushLayout { get; set; } = null!;

    public virtual ICollection<tMemberGetPush> tMemberGetPushes { get; set; } = new List<tMemberGetPush>();
}
