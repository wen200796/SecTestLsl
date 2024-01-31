using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCityDistrict
{
    public int fDistrictId { get; set; }

    public string fDistrictName { get; set; } = null!;

    public int fCityId { get; set; }

    public virtual tCity fCity { get; set; } = null!;

    public virtual ICollection<tVenue> tVenues { get; set; } = new List<tVenue>();
}
