namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;

    public class TeamSeasonService : FantasyDataApiBase, ITeamSeasonService
    {
        private static readonly string TeamSeasonKey = "TeamSeasonStats";

        public TeamSeasonService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public TeamSeasons Get(int season)
        {
            var url = string.Format("/{0}/{1}", TeamSeasonKey, season);
            return GetRequest<TeamSeasons>(url);
        }
    }
}
