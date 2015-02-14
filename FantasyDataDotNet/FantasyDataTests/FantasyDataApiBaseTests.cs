using FantasyData;
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
      var cut = new FantasyDataApiBase("http://api.nfldata.apiphany.com/trial/", "2be754f0c319454cb4832d0f524f596b", "d2ac4b33ae794fa5ae758dae48283441", true);

      var url = cut.BuildUrl("/DailyFantasyPlayers?data={0}", "2015=10-2"));

      Assert.IsNotNull(url);
    }
  }
}
