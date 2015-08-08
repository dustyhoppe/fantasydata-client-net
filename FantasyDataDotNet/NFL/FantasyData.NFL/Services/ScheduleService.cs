using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Utils;

namespace FantasyData.NFL.Services
{
    public class ScheduleService : FantasyDataApiBase, IScheduleService
    {
        private readonly string ScheduleKey = "Schedules";

        public ScheduleService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public ScheduledGames Get(int season, SeasonTypes seasonType)
        {
            string url = string.Format("/{0}/{1}", ScheduleKey, season.ToSeason(seasonType));
            return GetRequest<ScheduledGames>(url);
        }

        public async Task<ScheduledGames> GetAsync(int season, SeasonTypes seasonType)
        {
            string url = string.Format("/{0}/{1}", ScheduleKey, season.ToSeason(seasonType));
            return await GetRequestAsync<ScheduledGames>(url);
        }
    }
}
