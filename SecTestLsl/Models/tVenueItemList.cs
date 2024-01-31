using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenueItemList
{
    public int tVenueItemId { get; set; }

    public int? fVenueId { get; set; }

    public string? fItemName { get; set; }

    public virtual tVenue? fVenue { get; set; }
}
