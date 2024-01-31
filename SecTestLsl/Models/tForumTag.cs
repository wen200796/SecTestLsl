using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumTag
{
    public int fForumTagId { get; set; }

    public string fForumTagName { get; set; } = null!;

    public bool fForumTagStatus { get; set; }

    public virtual ICollection<tForumArticleTag> tForumArticleTags { get; set; } = new List<tForumArticleTag>();

    public virtual ICollection<tForumMemberFloTag> tForumMemberFloTags { get; set; } = new List<tForumMemberFloTag>();
}
