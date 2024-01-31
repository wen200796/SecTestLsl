using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVideoUploadUrl
{
    public int fVideoUploadUrl_Id { get; set; }

    public int fVideoCourseId { get; set; }

    public string? fVideoName { get; set; }

    public string? fVideoPath { get; set; }

    public DateTime? fUploadTime { get; set; }

    public virtual tVideoCourse fVideoCourse { get; set; } = null!;
}
