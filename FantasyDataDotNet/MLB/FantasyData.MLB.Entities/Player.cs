namespace FantasyData.MLB.Entities
{
    using System;
    using System.Collections.Generic;

    public class Players : List<Player>
    { }

    public class Player
    {
        public int PlayerID { get; set; }
        public string Status { get;set;}
        public int TeamID { get;set;}
        public string Team { get;set;}
        public int? Jersey { get;set;}
        public string PositionCategory { get;set;}
        public string Position { get;set;}
        public string MLBAMID  {get;set;}
        public string FirstName { get;set;}
        public string LastName { get;set;}
        public string PreferredFirstName { get;set;}
        public string BatHand { get;set;}
        public string ThrowHand { get;set;}
        public int Height { get;set;}
        public int Weight { get;set;}
        public DateTime BirthDate { get;set;}
        public string BirthCity { get;set;}
        public string BirthState { get;set;}
        public string BirthCountry {get;set;}
        public string HighSchool {get;set;}
        public string College {get;set;}
        public string ProDebut {get;set;}
        public int Salary { get;set;}
    }
}
