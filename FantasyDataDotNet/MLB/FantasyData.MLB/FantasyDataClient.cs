namespace FantasyData.MLB
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Services;
    using System;

    public class FantasyDataClient
    {
        #region Accessors

        public IStadiumService StadiumService { get; private set; }
        public IPlayerService PlayerService { get; private set; }
        public ITeamService TeamService { get; private set; }
        public IBoxScoreService BoxScoreService { get; private set; }
        public IGameService GameService { get; private set; }
        public IPlayerGameService PlayerGameService { get; private set; }
        public IPlayerSeasonService PlayerSeasonService { get; private set; }
        public ITeamGameService TeamGameService { get; private set; }
        public ITeamSeasonService TeamSeasonService { get; private set; }

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
            this.StadiumService = new StadiumService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.PlayerService = new PlayerService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.TeamService = new TeamService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.BoxScoreService = new BoxScoreService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.GameService = new GameService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.PlayerGameService = new PlayerGameService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.PlayerSeasonService = new PlayerSeasonService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.TeamGameService = new TeamGameService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            this.TeamSeasonService = new TeamSeasonService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
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
