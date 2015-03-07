namespace FantasyData.MLB.Entities
{
    using System.Collections.Generic;

    public class StadiumDetails : List<StadiumDetail>
    { }

    public class StadiumDetail
    {
        public int StadiumID { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Capacity { get; set; }
        public string Surface { get; set; }
        public int LeftField { get; set; }
        public int MidLeftField { get; set; }
        public int LeftCenterField { get; set; }
        public int MidLeftCenterField { get; set; }
        public int CenterField { get; set; }
        public int MidRightCenterField { get; set; }
        public int RightCenterField { get; set; }
        public int MidRightField { get; set; }
        public int RightField { get; set; }
    }
}
