using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tLessonBookVenue
{
    public int fLessonBookVenueId { get; set; }

    public int fLessonCourseId { get; set; }

    public int fVenueId { get; set; }

    public DateTime fBookDate { get; set; }

    public bool fBookIsValid { get; set; }

    public string? fBookStatusDesc { get; set; }

    public TimeSpan fBookStart { get; set; }

    public TimeSpan fBookEnd { get; set; }

    public virtual tLessonCourse fLessonCourse { get; set; } = null!;

    public virtual tVenue fVenue { get; set; } = null!;
}
