using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tTeacherEventLog
{
    public int fEventLogId { get; set; }

    public int fTeacherId { get; set; }

    public string fEventType { get; set; } = null!;

    public string fDescription { get; set; } = null!;

    public int fEmployeeId { get; set; }

    public DateTime fEmpRecordTime { get; set; }

    public virtual tTeacher fTeacher { get; set; } = null!;
}
