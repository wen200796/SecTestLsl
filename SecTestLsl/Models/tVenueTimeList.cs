using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenueTimeList
{
    public int fVenueTimeId { get; set; }

    public int fVenueId { get; set; }

    public DateTime fDate { get; set; }

    public TimeSpan fTime { get; set; }

    public bool fBookedStatus { get; set; }

    public int? fTeacherId { get; set; }

    public string? fChangeNote { get; set; }

    public virtual tTeacher? fTeacher { get; set; }

    public virtual tVenue fVenue { get; set; } = null!;
}
