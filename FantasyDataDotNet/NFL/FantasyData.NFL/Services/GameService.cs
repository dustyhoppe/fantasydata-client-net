using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class GameService : FantasyDataApiBase, IGameService
    {
        private static readonly string AreGamesInProgressKey = "AreAnyGamesInProgress";
        private static readonly string GameStatsByWeekKey = "GameStatsByWeek";
        private static readonly string GameStatsKey = "GameStats";

        public GameService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        /// <summary>
        /// Returns true if there is at least one game being played at the time of the request or false if there are none.
        /// </summary>
        public bool IsGameInProgress
        {
            get
            {
                string url = string.Format("/{0}", AreGamesInProgressKey);

                return GetBool(url);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public Games GetByWeek(int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}", GameStatsByWeekKey, season, week);
            return GetRequest<Games>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public Games GetBySeason(int season)
        {
            string url = string.Format("/{0}/{1}", GameStatsKey, season);
            return GetRequest<Games>(url);
        }
    }
}
