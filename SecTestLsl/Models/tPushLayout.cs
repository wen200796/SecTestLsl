using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tPushLayout
{
    public int fPushLayoutId { get; set; }

    public string? fLayoutName { get; set; }

    public virtual ICollection<tPushMessage> tPushMessages { get; set; } = new List<tPushMessage>();
}
