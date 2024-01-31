using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenuePicList
{
    public int fVenuePicId { get; set; }

    public int fVenueId { get; set; }

    public byte[]? fVenuePicLink { get; set; }

    public virtual tVenue fVenue { get; set; } = null!;
}
