namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;
    using FantasyData.Utils;

    using System;

    public class GameService : FantasyDataApiBase, IGameService
    {
        private static readonly string GamesByDateKey = "GamesByDate";
        private static readonly string GamesBySeasonKey = "Games";

        public GameService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public Games GetByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", GamesByDateKey, date.ToApiDate());
            return GetRequest<Games>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public Games GetBySeason(int season)
        {
            var url = string.Format("/{0}/{1}", GamesBySeasonKey, season);
            return GetRequest<Games>(url);
        }
    }
}
