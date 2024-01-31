using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumBoard
{
    public int fSubjectId { get; set; }

    public byte[]? fForumBoardImage { get; set; }

    public string? fForumBoardDescribe { get; set; }

    public int fForumBoardStatus { get; set; }

    public virtual tCourseSubject fSubject { get; set; } = null!;

    public virtual ICollection<tForumArticle> tForumArticles { get; set; } = new List<tForumArticle>();

    public virtual ICollection<tForumMemberFloBoard> tForumMemberFloBoards { get; set; } = new List<tForumMemberFloBoard>();

    public virtual ICollection<tForumMod> tForumMods { get; set; } = new List<tForumMod>();
}
