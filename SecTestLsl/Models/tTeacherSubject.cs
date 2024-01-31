using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tTeacherSubject
{
    public int fTeacherSujectsId { get; set; }

    public int fTeacherId { get; set; }

    public int fSubjectId { get; set; }

    public virtual tCourseSubject fSubject { get; set; } = null!;

    public virtual tTeacher fTeacher { get; set; } = null!;
}
