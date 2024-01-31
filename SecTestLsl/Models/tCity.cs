using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tCity
{
    public int fCityId { get; set; }

    public string fCityName { get; set; } = null!;

    public virtual ICollection<tCityDistrict> tCityDistricts { get; set; } = new List<tCityDistrict>();

    public virtual ICollection<tMemberCitiesList> tMemberCitiesLists { get; set; } = new List<tMemberCitiesList>();
}
