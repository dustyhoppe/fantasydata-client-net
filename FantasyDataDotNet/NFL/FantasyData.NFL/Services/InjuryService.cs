using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class InjuryService : FantasyDataApiBase, IInjuryService
    {
        private static readonly string InjuriesKey = "Injuries";

        public InjuryService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public Injuries GetByWeek(int season, int week)
        {
            var url = string.Format("/{0}/{1}/{2}", InjuriesKey, season, week);

            return GetRequest<Injuries>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<Injuries> GetByWeekAsync(int season, int week)
        {
            var url = string.Format("/{0}/{1}/{2}", InjuriesKey, season, week);

            return await this.GetRequestAsync<Injuries>(url);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="team"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public Injuries GetByWeekAndTeam(TeamTypes team, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", InjuriesKey, season, week, team.ToString());

            return GetRequest<Injuries>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="team"></param>
        /// <param name="week"></param>
        /// <param name="season"></param>
        /// <returns></returns>
        public async Task<Injuries> GetByWeekAndTeamAsync(TeamTypes team, int season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}/{3}", InjuriesKey, season, week, team.ToString());

            return await this.GetRequestAsync<Injuries>(url);
        }
    }
}
