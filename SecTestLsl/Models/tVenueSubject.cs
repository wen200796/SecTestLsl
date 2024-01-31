using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenueSubject
{
    public int ftVenueSubjectId { get; set; }

    public int? fVenueId { get; set; }

    public int? fSubjectId { get; set; }

    public virtual tCourseSubject? fSubject { get; set; }

    public virtual tVenue? fVenue { get; set; }
}
