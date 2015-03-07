namespace FantasyData.MLB.Entities
{
    using System.Collections.Generic;

    public class Teams : List<Team>
    { }

    public class Team
    {
        public int TeamID { get; set; }
        public string Key { get; set; }
        public bool Active { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public int StadiumID { get; set; }
        public string League { get; set; }
        public string Division { get; set; }
    }
}
