using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVideoCourse
{
    public int fVideoCourseId { get; set; }

    public int fSubjectId { get; set; }

    public string? fCode { get; set; }

    public int fTeacherId { get; set; }

    public string? fName { get; set; }

    public string? fDescription { get; set; }

    public string? fRequirement { get; set; }

    public byte[]? fCoursePhoto { get; set; }

    public decimal? fPrice { get; set; }

    public string fHomeworkDescription { get; set; } = null!;

    public string? fValidate { get; set; }

    public bool fLaunchStatus { get; set; }

    public DateTime? fUploadDate { get; set; }

    public string? fNote { get; set; }

    public DateTime? fUpdateDate { get; set; }

    public virtual tCourseSubject fSubject { get; set; } = null!;

    public virtual tTeacher fTeacher { get; set; } = null!;

    public virtual ICollection<tVideoCourseEvaluation> tVideoCourseEvaluations { get; set; } = new List<tVideoCourseEvaluation>();

    public virtual ICollection<tVideoCourseQA> tVideoCourseQAs { get; set; } = new List<tVideoCourseQA>();

    public virtual ICollection<tVideoUploadUrl> tVideoUploadUrls { get; set; } = new List<tVideoUploadUrl>();
}
