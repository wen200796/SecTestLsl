using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCourseworkFile
{
    public int fCourseworkFileId { get; set; }

    public int fCourseworkId { get; set; }

    public string fFileName { get; set; } = null!;

    public string? fFileFormat { get; set; }

    public string? fFileLink { get; set; }

    public int fFileSize { get; set; }

    public virtual tCoursework fCoursework { get; set; } = null!;
}
