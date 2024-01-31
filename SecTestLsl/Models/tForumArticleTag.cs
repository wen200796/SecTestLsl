using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumArticleTag
{
    public int fForumArticleTagId { get; set; }

    public int fForumTagId { get; set; }

    public int fForumArticleId { get; set; }

    public virtual tForumArticle fForumArticle { get; set; } = null!;

    public virtual tForumTag fForumTag { get; set; } = null!;
}
