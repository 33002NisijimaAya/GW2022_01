using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodgingSearchSystem
{

    public class Rootobject
    {
        public Paginginfo pagingInfo { get; set; }
        public Hotel[] hotels { get; set; }
    }

    public class Paginginfo
    {
        public int recordCount { get; set; }
        public int pageCount { get; set; }
        public int page { get; set; }
        public int first { get; set; }
        public int last { get; set; }
    }

    public class Hotel
    {
        public Hotel1[] hotel { get; set; }
    }

    public class Hotel1
    {
        public Hotelbasicinfo hotelBasicInfo { get; set; }
        public Hotelratinginfo hotelRatingInfo { get; set; }
    }

    public class Hotelbasicinfo
    {
        public int hotelNo { get; set; }
        public string hotelName { get; set; }
        public string hotelInformationUrl { get; set; }
        public string planListUrl { get; set; }
        public string dpPlanListUrl { get; set; }
        public string reviewUrl { get; set; }
        public string hotelKanaName { get; set; }
        public string hotelSpecial { get; set; }
        public int? hotelMinCharge { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string postalCode { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string telephoneNo { get; set; }
        public string faxNo { get; set; }
        public string access { get; set; }
        public string parkingInformation { get; set; }
        public string nearestStation { get; set; }
        public string hotelImageUrl { get; set; }
        public string hotelThumbnailUrl { get; set; }
        public string roomImageUrl { get; set; }
        public string roomThumbnailUrl { get; set; }
        public string hotelMapImageUrl { get; set; }
        public int? reviewCount { get; set; }
        public float? reviewAverage { get; set; }
        public string userReview { get; set; }
    }

    public class Hotelratinginfo
    {
        public float? serviceAverage { get; set; }
        public float? locationAverage { get; set; }
        public float? roomAverage { get; set; }
        public float? equipmentAverage { get; set; }
        public float? bathAverage { get; set; }
        public float? mealAverage { get; set; }
    }

}
