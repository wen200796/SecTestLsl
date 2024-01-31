using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumMemberCollectArticle
{
    public int fForumMemberCollectArticleId { get; set; }

    public int fForumMemberId { get; set; }

    public int fForumArticleId { get; set; }

    public virtual tForumArticle fForumArticle { get; set; } = null!;

    public virtual tForumMember fForumMember { get; set; } = null!;
}
