namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;

    public class PlayerSeasonService : FantasyDataApiBase, IPlayerSeasonService
    {
        private static readonly string PlayerSeasonsBySeason = "PlayerSeasonStats";
        private static readonly string PlayerSeasonsByTeam = "PlayerSeasonStatsByTeam";

        public PlayerSeasonService(string baseApiUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseApiUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public PlayerSeasons Get(int season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonsBySeason, season);
            return GetRequest<PlayerSeasons>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns></returns>
        public PlayerSeasons GetByTeam(int season, string shortName)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonsByTeam, season, shortName);
            return GetRequest<PlayerSeasons>(url);
        }
    }
}
