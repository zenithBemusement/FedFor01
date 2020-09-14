using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FedFor01.ModelsSingle
{


    public class Rootobject
    {
        public string FacilityID { get; set; }
        public string LegacyFacilityID { get; set; }
        public string OrgFacilityID { get; set; }
        public string ParentOrgID { get; set; }
        public string ParentRecAreaID { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public string FacilityTypeDescription { get; set; }
        public string FacilityUseFeeDescription { get; set; }
        public string FacilityDirections { get; set; }
        public string FacilityPhone { get; set; }
        public string FacilityEmail { get; set; }
        public string FacilityReservationURL { get; set; }
        public string FacilityMapURL { get; set; }
        public string FacilityAdaAccess { get; set; }
        //public GEOJSON GEOJSON { get; set; }
        public float FacilityLongitude { get; set; }
        public float FacilityLatitude { get; set; }
        public string StayLimit { get; set; }
        public string Keywords { get; set; }
        public bool Reservable { get; set; }
        public bool Enabled { get; set; }
        public string LastUpdatedDate { get; set; }
        //public CAMPSITE[] CAMPSITE { get; set; }
        //public PERMITENTRANCE[] PERMITENTRANCE { get; set; }
        //public TOUR[] TOUR { get; set; }
        //public ORGANIZATION[] ORGANIZATION { get; set; }
        //public RECAREA[] RECAREA { get; set; }
        //public FACILITYADDRESS[] FACILITYADDRESS { get; set; }
        //public ACTIVITY[] ACTIVITY { get; set; }
        //public EVENT[] EVENT { get; set; }
        //public LINK[] LINK { get; set; }
        //public Medium[] MEDIA { get; set; }
    }

    //public class GEOJSON
    //{
    //    public string TYPE { get; set; }
    //    public float[] COORDINATES { get; set; }
    //}

    //public class CAMPSITE
    //{
    //    public string CampsiteID { get; set; }
    //    public string CampsiteName { get; set; }
    //    public string ResourceLink { get; set; }
    //}

    //public class PERMITENTRANCE
    //{
    //    public string PermitEntranceID { get; set; }
    //    public string PermitEntranceName { get; set; }
    //    public string ResourceLink { get; set; }
    //}

    //public class TOUR
    //{
    //    public string TourID { get; set; }
    //    public string TourName { get; set; }
    //    public string ResourceLink { get; set; }
    //}

    //public class ORGANIZATION
    //{
    //    public string OrgID { get; set; }
    //    public string OrgName { get; set; }
    //    public string OrgImageURL { get; set; }
    //    public string OrgURLText { get; set; }
    //    public string OrgURLAddress { get; set; }
    //    public string OrgType { get; set; }
    //    public string OrgAbbrevName { get; set; }
    //    public string OrgJurisdictionType { get; set; }
    //    public int OrgParentID { get; set; }
    //    public string LastUpdatedDate { get; set; }
    //}

    //public class RECAREA
    //{
    //    public string RecAreaID { get; set; }
    //    public string RecAreaName { get; set; }
    //    public string ResourceLink { get; set; }
    //}

    //public class FACILITYADDRESS
    //{
    //    public string FacilityAddressID { get; set; }
    //    public string FacilityID { get; set; }
    //    public string FacilityAddressType { get; set; }
    //    public string FacilityStreetAddress1 { get; set; }
    //    public string FacilityStreetAddress2 { get; set; }
    //    public string FacilityStreetAddress3 { get; set; }
    //    public string City { get; set; }
    //    public string PostalCode { get; set; }
    //    public string AddressStateCode { get; set; }
    //    public string AddressCountryCode { get; set; }
    //    public string LastUpdatedDate { get; set; }
    //}

    //public class ACTIVITY
    //{
    //    public string ActivityID { get; set; }
    //    public string FacilityID { get; set; }
    //    public string ActivityName { get; set; }
    //    public string FacilityActivityDescription { get; set; }
    //    public string FacilityActivityFeeDescription { get; set; }
    //}

    //public class EVENT
    //{
    //    public string EventID { get; set; }
    //    public string EventName { get; set; }
    //    public string ResourceLink { get; set; }
    //}

    //public class LINK
    //{
    //    public string EntityLinkID { get; set; }
    //    public string LinkType { get; set; }
    //    public string EntityID { get; set; }
    //    public string EntityType { get; set; }
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    public string URL { get; set; }
    //}

    //public class Medium
    //{
    //    public string EntityMediaID { get; set; }
    //    public string MediaType { get; set; }
    //    public string EntityID { get; set; }
    //    public string EntityType { get; set; }
    //    public string Title { get; set; }
    //    public string Subtitle { get; set; }
    //    public string Description { get; set; }
    //    public string EmbedCode { get; set; }
    //    public int Height { get; set; }
    //    public int Width { get; set; }
    //    public bool IsPrimary { get; set; }
    //    public bool IsPreview { get; set; }
    //    public bool IsGallery { get; set; }
    //    public string URL { get; set; }
    //    public string Credits { get; set; }
    //}

    //public class OneFacilityModel
    //{
    //    [Key]
    //    public string FacilityID { get; set; }
    //    public string LegacyFacilityID { get; set; }
    //    public string OrgFacilityID { get; set; }
    //    public string ParentOrgID { get; set; }
    //    public string ParentRecAreaID { get; set; }
    //    public string FacilityName { get; set; }
    //    public string FacilityDescription { get; set; }
    //    public string FacilityTypeDescription { get; set; }
    //    public string FacilityUseFeeDescription { get; set; }
    //    public string FacilityDirections { get; set; }
    //    public string FacilityPhone { get; set; }
    //    public string FacilityEmail { get; set; }
    //    public string FacilityReservationURL { get; set; }
    //    public string FacilityMapURL { get; set; }
    //    public string FacilityAdaAccess { get; set; }
    //    public GEOJSON GEOJSON { get; set; }
    //    public float FacilityLongitude { get; set; }
    //    public float FacilityLatitude { get; set; }
    //    public string StayLimit { get; set; }
    //    public string Keywords { get; set; }
    //    public bool Reservable { get; set; }
    //    public bool Enabled { get; set; }
    //    public string LastUpdatedDate { get; set; }
    //    public IEnumerable<FedFor01.Models.OneFacilityModel> ListOfData { get; set; }


    //}

    //public class OneFacilityModelList
    //{
    //    public IEnumerable<FedFor01.Models.OneFacilityModel> ListOfData { get; set; }
    //}

}