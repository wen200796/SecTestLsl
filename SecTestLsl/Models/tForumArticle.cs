using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumArticle
{
    public int fForumArticleId { get; set; }

    public int fForumBoardId { get; set; }

    public string fForumTilte { get; set; } = null!;

    public int fForumMemberId { get; set; }

    public string? fForumArticleContent { get; set; }

    public DateTime fForumArticleTime { get; set; }

    public DateTime? fForumLastEditArticleTime { get; set; }

    public int fForumArticleStatus { get; set; }

    public virtual tForumBoard fForumBoard { get; set; } = null!;

    public virtual tForumMember fForumMember { get; set; } = null!;

    public virtual ICollection<tForumArticleComment> tForumArticleComments { get; set; } = new List<tForumArticleComment>();

    public virtual ICollection<tForumArticleTag> tForumArticleTags { get; set; } = new List<tForumArticleTag>();

    public virtual ICollection<tForumMemberCollectArticle> tForumMemberCollectArticles { get; set; } = new List<tForumMemberCollectArticle>();
}
