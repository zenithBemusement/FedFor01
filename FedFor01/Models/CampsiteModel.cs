using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FedFor01.CampsiteModel
{

    public class Rootobject
    {
        public campsiteRECDATA[] RECDATA { get; set; }
        public campsiteMETADATA METADATA { get; set; }
    }

    public class campsiteMETADATA
    {
        public RESULTS RESULTS { get; set; }
        public PARAMETERS PARAMETERS { get; set; }
    }

    public class RESULTS
    {
        public int CURRENT_COUNT { get; set; }
        public int TOTAL_COUNT { get; set; }
    }

    public class PARAMETERS
    {
        public string QUERY { get; set; }
        public int LIMIT { get; set; }
        public int OFFSET { get; set; }
    }

    public class campsiteRECDATA
    {
        public string CampsiteID { get; set; }
        public string FacilityID { get; set; }
        public string CampsiteName { get; set; }
        public string CampsiteType { get; set; }
        public string TypeOfUse { get; set; }
        public string Loop { get; set; }
        public bool CampsiteAccessible { get; set; }
        public float CampsiteLongitude { get; set; }
        public float CampsiteLatitude { get; set; }
        public string CreatedDate { get; set; }
        public string LastUpdatedDate { get; set; }
        public ATTRIBUTE[] ATTRIBUTES { get; set; }
        public PERMITTEDEQUIPMENT[] PERMITTEDEQUIPMENT { get; set; }
        public ENTITYMEDIA[] ENTITYMEDIA { get; set; }
    }

    public class ATTRIBUTE
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
    }

    public class PERMITTEDEQUIPMENT
    {
        public string EquipmentName { get; set; }
        public int MaxLength { get; set; }
    }

    public class ENTITYMEDIA
    {
        public string EntityMediaID { get; set; }
        public string MediaType { get; set; }
        public string EntityID { get; set; }
        public string EntityType { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string EmbedCode { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsPreview { get; set; }
        public bool IsGallery { get; set; }
        public string URL { get; set; }
        public string Credits { get; set; }
    }

}