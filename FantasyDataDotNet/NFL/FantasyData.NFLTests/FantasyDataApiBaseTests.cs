using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using FantasyData.NFL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyDataTests
{
    [TestClass]
    public class FantasyDataApiBaseTests
    {

        [TestMethod]
        public void TestMethod1()
        {
            var client = new FantasyDataClient();

            var response = client.DailyFantasyService.GetDailyFantasyPlayers(new DateTime(2014, 9, 21));

            Assert.IsNotNull(response);
        }

        /*
        [TestMethod]
        public void CurrentSeason_Is_2014()
        {
          var client = new FantasyDataClient();

          var response = client.SeasonService.GetByeWeeks(2014);

          Assert.IsTrue(response.Count() == 32);
        }

        [TestMethod]
        public void Get_News_Count_GreaterThanZero()
        {
          var client = new FantasyDataClient();

          var response = client.NewsService.Get();

          Assert.IsTrue(response.Count() > 0);
        }

        [TestMethod]
        public void Get_News_Count_For_Denver_GreaterThanZero()
        {
          var client = new FantasyDataClient();

          var response = client.NewsService.GetForTeam(Teams.DEN);

          Assert.IsTrue(response.Count() > 0);
        }

        [TestMethod]
        public void Get_News_Count_For_PlayerID4631_GreaterThanZero()
        {
          var client = new FantasyDataClient();

          var response = client.NewsService.GetForPlayer(4631);

          Assert.IsTrue(response.Count() > 0);
        }
        */

        [TestMethod]
        public void Get_PlayerGameStats_ForPeytonManning_Week1_2014()
        {
            var client = new FantasyDataClient();

            var response = client.PlayerGameStatService.GetByGame(7328, 1, 2014);

            Assert.IsTrue(response.PassingTouchdowns == 3);
        }

        [TestMethod]
        public void Get_BoxScore_ForWashington_Week1_2013()
        {
            var client = new FantasyDataClient();

            var response = client.BoxScoreService.Get(2013, 1, "WAS");

            Assert.IsTrue(response != null);
        }
    }
}
