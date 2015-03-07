using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FantasyData.MLB;
using System.Diagnostics;

namespace FantasyData.MLBTests
{
    [TestClass]
    public class FantasyDataClientTests
    {
        /// <summary>
        /// Get Active Players interagtion test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2f6b14338d0f80af6ccb/console</url>
        [TestMethod]
        public void Get_ActivePlayers_Count_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerService.GetActive();
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        /// Get Active Teams interagtion test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bb629614338d0950b86e00/console</url>
        [TestMethod]
        public void Get_ActiveTeams_Count_Equals_30()
        {
            var client = new FantasyDataClient();
            var result = client.TeamService.Get();
            Assert.IsTrue(result.Count == 30);
        }

        /// <summary>
        /// Get Box Score integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54d3023d35491a0c6c7fcb12/console</url>
        [TestMethod]
        public void Get_BoxScore_ForGameID_14620_InningCount_Equals_9()
        {
            var client = new FantasyDataClient();
            var result = client.BoxScoreService.Get(14620);
            Assert.IsTrue(result.Innings.Count == 9);
        }
        
        /// <summary>
        /// Get Box Scores by Date integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54d3023535491a0c6c7fcb11/console</url>
        [TestMethod]
        public void Get_BoxScores_ByDate_2014_JUL_31_GameCount_Equals_11()
        {
            var client = new FantasyDataClient();
            var result = client.BoxScoreService.GetByDate(new DateTime(2014, 7, 31));
            Assert.IsTrue(result.Count == 11);
        }

        /// <summary>
        /// Get Free Agents integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2f9014338d0f80af6ccc/console</url>
        [TestMethod]
        public void Get_FreeAgents_Count_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerService.GetFreeAgents();
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        /// Get Games By Date integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2eb614338d0f80af6cca/console</url>
        [TestMethod]
        public void Get_GamesForDate_2014_JUL_31_Count_Equals11()
        {
            var client = new FantasyDataClient();
            var result = client.GameService.GetByDate(new DateTime(2014, 7, 31));
            Assert.IsTrue(result.Count == 11);
        }

        /// <summary>
        /// Get Games By Season integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2b9814338d0f80af6cc5/console</url>
        [TestMethod]
        public void Get_GamesBySeason_2014_Count_Equals_2498()
        {
            var client = new FantasyDataClient();
            var result = client.GameService.GetBySeason(2014);
            Assert.IsTrue(result.Count == 2498);
        }

        /// <summary>
        /// Get Player Games by Date integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf309614338d0f80af6cce/console</url>
        [TestMethod]
        public void Get_PlayerGamesByDate_2014_JUL_31_Count_Equals_321()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerGameService.GetByDate(new DateTime(2014, 7, 31));
            Assert.IsTrue(result.Count == 321);
        }

        /// <summary>
        /// Get Player Season Stats integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54c00cec14338d0f80af6ccf/console</url>
        [TestMethod]
        public void Get_PlayerSeasonStats_2014_Count_Equals_1550()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerSeasonService.Get(2014);
            Assert.IsTrue(result.Count == 1550);
        }

        /// <summary>
        /// Get Player Season Stats by Team integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54c00d2214338d0f80af6cd0/console</url>
        [TestMethod]
        public void Get_PlayerSeasonStatsByTeam_2014_NYY_Count_Equals_52()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerSeasonService.GetByTeam(2014, "NYY");
            Debug.WriteLine("Get PlayerSeasonStatsByTeam NYY : Count {0}", result.Count);
            Assert.IsTrue(result.Count == 52);
        }

        /// <summary>
        /// Get Players by Team interagtion test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2fc414338d0f80af6ccd/console</url>
        [TestMethod]
        public void Get_PlayersByTeam_NYY_Count_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var result = client.PlayerService.GetByTeam("NYY");
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        /// Stadiums integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54bf2b6314338d0f80af6cc4/console</url>
        [TestMethod]
        public void Get_StadiumDetails_Count_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var result = client.StadiumService.Get();
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        /// Get Team Game Stats By Date integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54d06ce114338d088c895fb3/console</url>
        [TestMethod]
        public void Get_TeamGameStatsByDate_2014_JUL_31_Count_Equals_22()
        {
            var client = new FantasyDataClient();
            var result = client.TeamGameService.GetByDate(new DateTime(2014, 7, 31));
            Debug.WriteLine("Get TeamGameStatsByDate 2014-JUL-31 : Count {0}", result.Count);
            Assert.IsTrue(result.Count == 22);
        }

        /// <summary>
        /// Get Team Stats By Season integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/54bb5fd214338d0950b86dfe/operations/54d06ceb14338d088c895fb4/console</url>
        [TestMethod]
        public void Get_TeamGameStatsBySeason_2014_Count_Equals_40()
        {
            var client = new FantasyDataClient();
            var result = client.TeamSeasonService.Get(2014);
            Debug.WriteLine("Get TeamGameStatsByDate 2014 : Count {0}", result.Count);
            Assert.IsTrue(result.Count == 40);
        }
    }
}
