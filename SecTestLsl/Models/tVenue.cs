using System;
using System.Collections.Generic;

namespace SecTestLsl.Models;

public partial class tVenue
{
    public int fVenueId { get; set; }

    public int fVenueProviderId { get; set; }

    public string fVenueCode { get; set; } = null!;

    public string fVenueName { get; set; } = null!;

    public int fDistrictId { get; set; }

    public string fAddressDetail { get; set; } = null!;

    public DateTime? fAddedTime { get; set; }

    public short fMaxPeople { get; set; }

    public decimal fPriceHalfHr { get; set; }

    public bool fOpenStatus { get; set; }

    public bool fReviewStatus { get; set; }

    public string? fNote { get; set; }

    public virtual tCityDistrict fDistrict { get; set; } = null!;

    public virtual tVenueProviderInfo fVenueProvider { get; set; } = null!;

    public virtual ICollection<tLessonBookVenue> tLessonBookVenues { get; set; } = new List<tLessonBookVenue>();

    public virtual ICollection<tVenueItemList> tVenueItemLists { get; set; } = new List<tVenueItemList>();

    public virtual ICollection<tVenuePicList> tVenuePicLists { get; set; } = new List<tVenuePicList>();

    public virtual ICollection<tVenueSubject> tVenueSubjects { get; set; } = new List<tVenueSubject>();

    public virtual ICollection<tVenueTimeList> tVenueTimeLists { get; set; } = new List<tVenueTimeList>();
}
