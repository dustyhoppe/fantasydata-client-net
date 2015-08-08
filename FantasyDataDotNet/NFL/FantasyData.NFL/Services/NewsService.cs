using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class NewsService : FantasyDataApiBase, INewsService
    {
        private static readonly string NewsKey = "News";
        private static readonly string NewsByTeamKey = "NewsByTeam";
        private static readonly string NewsByPlayerIDKey = "NewsByPlayerID";

        public NewsService(string baseUrl, string primarySusbscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySusbscriptionKey, secondarySubscriptionKey)
        { }


        public News Get()
        {
            var url = string.Format("/{0}", NewsKey);

            return GetRequest<News>(url);
        }

        public async Task<News> GetAsync()
        {
            var url = string.Format("/{0}", NewsKey);

            return await this.GetRequestAsync<News>(url);
        }


        public News GetForTeam(TeamTypes team)
        {
            var url = string.Format("/{0}/{1}", NewsByTeamKey, team.ToString());

            return GetRequest<News>(url);
        }

        public async Task<News> GetForTeamAsync(TeamTypes team)
        {
            var url = string.Format("/{0}/{1}", NewsByTeamKey, team.ToString());

            return await this.GetRequestAsync<News>(url);
        }


        public News GetForPlayer(int playerId)
        {
            var url = string.Format("/{0}/{1}", NewsByPlayerIDKey, playerId);

            return GetRequest<News>(url);
        }

        public async Task<News> GetForPlayerAsync(int playerId)
        {
            var url = string.Format("/{0}/{1}", NewsByPlayerIDKey, playerId);

            return await this.GetRequestAsync<News>(url);
        }
    }
}
