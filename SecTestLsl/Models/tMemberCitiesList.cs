using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tMemberCitiesList
{
    public int fMCitiesId { get; set; }

    public int fMemberId { get; set; }

    public int fCityId { get; set; }

    public virtual tCity fCity { get; set; } = null!;

    public virtual tMember fMember { get; set; } = null!;
}
