using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenueProviderInfo
{
    public int fVenueProviderId { get; set; }

    public string fName { get; set; } = null!;

    public string fGUInumber { get; set; } = null!;

    public string fPassword { get; set; } = null!;

    public string fContactName { get; set; } = null!;

    public string fPhone { get; set; } = null!;

    public string fEmail { get; set; } = null!;

    public virtual ICollection<tVenue> tVenues { get; set; } = new List<tVenue>();
}
