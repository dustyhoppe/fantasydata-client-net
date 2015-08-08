using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class PlayerGameStatService : FantasyDataApiBase, IPlayerGameStatService
    {
        private static readonly string PlayerGameStatsByPlayerKey = "PlayerGameStatsByPlayerID";
        private static readonly string PlayerGameStatsByTeamKey = "PlayerGameStatsByTeam";
        private static readonly string PlayerGameStatsByWeekKey = "PlayerGameStatsByWeek";

        public PlayerGameStatService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public PlayerGame GetByGame(int playerId, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByPlayerKey, season, week, playerId);

            return GetRequest<PlayerGame>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<PlayerGame> GetByGameAsync(int playerId, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByPlayerKey, season, week, playerId);

            return await this.GetRequestAsync<PlayerGame>(url);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="team"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public PlayerGames GetByTeamAndWeek(TeamTypes team, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByTeamKey, season, week, team.ToString());

            return GetRequest<PlayerGames>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="team"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<PlayerGames> GetByTeamAndWeekAsync(TeamTypes team, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByTeamKey, season, week, team.ToString());

            return await this.GetRequestAsync<PlayerGames>(url);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public PlayerGames GetByWeek(int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}", PlayerGameStatsByWeekKey, season, week);

            return GetRequest<PlayerGames>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<PlayerGames> GetByWeekAsync(int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}", PlayerGameStatsByWeekKey, season, week);

            return await this.GetRequestAsync<PlayerGames>(url);
        }
    }
}
