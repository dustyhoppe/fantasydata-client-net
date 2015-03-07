namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;
    using FantasyData.Utils;

    using System;

    public class PlayerGameService : FantasyDataApiBase, IPlayerGameService
    {
        private static readonly string PlayerGameStatsByDateKey = "PlayerGameStatsByDate";

        public PlayerGameService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public PlayerGames GetByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", PlayerGameStatsByDateKey, date.ToApiDate());
            return GetRequest<PlayerGames>(url);
        }
    }
}
