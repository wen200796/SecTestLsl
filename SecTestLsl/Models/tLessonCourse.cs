using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tLessonCourse
{
    public int fLessonCourseId { get; set; }

    public int fSubjectId { get; set; }

    public string? fCode { get; set; }

    public int fTeacherId { get; set; }

    public string fName { get; set; } = null!;

    public string? fDescription { get; set; }

    public string? fRequirement { get; set; }

    public byte[]? fCoursePhoto { get; set; }

    public decimal fPrice { get; set; }

    public string fHomeworkDescription { get; set; } = null!;

    public int fMaxPeople { get; set; }

    public int fMinPeople { get; set; }

    public DateTime fLessonDate { get; set; }

    public TimeSpan fLessonStartTime { get; set; }

    public TimeSpan fLessonEndTime { get; set; }

    public int fLessonVenue { get; set; }

    public string? fLessonVenueInfo { get; set; }

    public int? fLessonBookVenueId { get; set; }

    public DateTime fLessonRegStart { get; set; }

    public DateTime fLessonRegDeadline { get; set; }

    public bool fLaunchStatus { get; set; }

    public string? fNote { get; set; }

    public virtual tCourseSubject fSubject { get; set; } = null!;

    public virtual tTeacher fTeacher { get; set; } = null!;

    public virtual ICollection<tLessonBookVenue> tLessonBookVenues { get; set; } = new List<tLessonBookVenue>();

    public virtual ICollection<tLessonCourseEvaluation> tLessonCourseEvaluations { get; set; } = new List<tLessonCourseEvaluation>();

    public virtual ICollection<tLessonCourseQA> tLessonCourseQAs { get; set; } = new List<tLessonCourseQA>();
}
