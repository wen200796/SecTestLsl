using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumArticleComment
{
    public int fForumCommentId { get; set; }

    public int fForumArticleId { get; set; }

    public int fForumMemberId { get; set; }

    public int fForumParentFloor { get; set; }

    public int fForumSubFloor { get; set; }

    public int fForumParentCommentId { get; set; }

    public string? fForumCommentContent { get; set; }

    public DateTime fForumCommentTime { get; set; }

    public DateTime? fForumLastCommentEditTime { get; set; }

    public int fForumCommentStatus { get; set; }

    public virtual tForumArticle fForumArticle { get; set; } = null!;

    public virtual tForumMember fForumMember { get; set; } = null!;
}
