using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tTeacherImage
{
    public int fTeacherImagesId { get; set; }

    public int fTeacherId { get; set; }

    public string fImageName { get; set; } = null!;

    public byte[]? fImageLink { get; set; }

    public int fImageSize { get; set; }

    public virtual tTeacher fTeacher { get; set; } = null!;
}
