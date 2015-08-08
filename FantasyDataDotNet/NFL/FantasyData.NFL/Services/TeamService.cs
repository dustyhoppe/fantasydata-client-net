using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class TeamService : FantasyDataApiBase, ITeamService
    {
        private static readonly string StandingsKey = "Standings";
        private static readonly string TeamsKey = "Teams";

        public TeamService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public Standings GetStandingsBySeason(int season)
        {
            string url = string.Format("/{0}/{1}", StandingsKey, season);
            return GetRequest<Standings>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<Standings> GetStandingsBySeasonAsync(int season)
        {
            string url = string.Format("/{0}/{1}", StandingsKey, season);
            return await this.GetRequestAsync<Standings>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Teams Get()
        {
            string url = string.Format("/{0}", TeamsKey);
            return GetRequest<Teams>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<Teams> GetAsync()
        {
            string url = string.Format("/{0}", TeamsKey);
            return await this.GetRequestAsync<Teams>(url);
        }
    }
}
