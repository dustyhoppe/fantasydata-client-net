using FantasyData.NFL.Services;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL
{
    public class FantasyDataClient
    {
        #region Accessors

        public IDailyFantasyService DailyFantasyService { get; private set; }
        public ISeasonService SeasonService { get; private set; }
        public INewsService NewsService { get; private set; }
        public IPlayerGameStatService PlayerGameStatService { get; private set; }
        public IPlayerSeasonStatService PlayerSeasonStatService { get; private set; }
        public ITeamDefenseService TeamDefenseService { get; private set; }
        public IGameService GameService { get; private set; }
        public IInjuryService InjuryService { get; private set; }
        public IStadiumService StadiumService { get; private set; }
        public ITeamService TeamService { get; private set; }
        public IBoxScoreService BoxScoreService { get; private set; }
        public IPlayerService PlayerService { get; private set; }
        public IScheduleService ScheduleService { get; private set; }

        #endregion


        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>
        public FantasyDataClient(Uri apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            DailyFantasyService = new DailyFantasyService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonService = new SeasonService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            NewsService = new NewsService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerGameStatService = new PlayerGameStatService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerSeasonStatService = new PlayerSeasonStatService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamDefenseService = new TeamDefenseService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameService = new GameService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            InjuryService = new InjuryService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StadiumService = new StadiumService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamService = new TeamService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScoreService = new BoxScoreService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerService = new PlayerService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ScheduleService = new ScheduleService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasyDataClient()
            : this(Config.ApiBaseUrl, Config.PrimarySubscriptionKey, Config.SecondarySubscriptionKey)
        { }


        #endregion
    }
}
