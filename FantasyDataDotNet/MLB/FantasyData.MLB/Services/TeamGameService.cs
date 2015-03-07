namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;
    using FantasyData.Utils;

    using System;

    public class TeamGameService : FantasyDataApiBase, ITeamGameService
    {
        private static readonly string TeamGameKey = "TeamGameStatsByDate";

        public TeamGameService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public TeamGames GetByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", TeamGameKey, date.ToApiDate());
            return GetRequest<TeamGames>(url);
        }
    }
}
