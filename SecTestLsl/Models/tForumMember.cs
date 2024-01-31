using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tForumMember
{
    public int fMemberId { get; set; }

    public string fForumMemberNickname { get; set; } = null!;

    public bool fForumMemberPermission { get; set; }

    public int fForumMemberStatus { get; set; }

    public virtual tMember fMember { get; set; } = null!;

    public virtual ICollection<tForumArticleComment> tForumArticleComments { get; set; } = new List<tForumArticleComment>();

    public virtual ICollection<tForumArticle> tForumArticles { get; set; } = new List<tForumArticle>();

    public virtual ICollection<tForumMemberCollectArticle> tForumMemberCollectArticles { get; set; } = new List<tForumMemberCollectArticle>();

    public virtual ICollection<tForumMemberFloBoard> tForumMemberFloBoards { get; set; } = new List<tForumMemberFloBoard>();

    public virtual ICollection<tForumMemberFloMember> tForumMemberFloMemberfForumIsFloMembers { get; set; } = new List<tForumMemberFloMember>();

    public virtual ICollection<tForumMemberFloMember> tForumMemberFloMemberfForumMembers { get; set; } = new List<tForumMemberFloMember>();

    public virtual ICollection<tForumMemberFloTag> tForumMemberFloTags { get; set; } = new List<tForumMemberFloTag>();

    public virtual ICollection<tForumMod> tForumMods { get; set; } = new List<tForumMod>();
}
