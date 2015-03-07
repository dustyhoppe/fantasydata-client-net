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
  public class ConfigTests
  {
    // trial config values
    private const string TrialPrimarySubscriptionKey = "2be754f0c319454cb4832d0f524f596b";
    private const string TrialSecondarySubscriptionKey = "d2ac4b33ae794fa5ae758dae48283441";
    private const string TrialApiBaseUrl = "http://api.nfldata.apiphany.com/trial/";

    // developer config values
    private const string DeveloperPrimarySubscriptionKey = "2be754f0c319454cb4832d0f524f596b";
    private const string DeveloperSecondarySubscriptionKey = "d2ac4b33ae794fa5ae758dae48283441";
    private const string DeveloperApiBaseUrl = "http://api.nfldata.apiphany.com/developer/";


    //[TestMethod]
    //public void TrialSubscription_ApiBaseUrl_IsNotNull()
    //{
    //  var value = Config.ApiBaseUrl;

    //  Assert.IsNotNull(value);
    //}

    //[TestMethod]
    //public void TrialSubscription_PrimarySubscriptionKey_Matches()
    //{
    //  var value = Config.PrimarySubscriptionKey;

    //  Assert.AreEqual(value, TrialPrimarySubscriptionKey);
    //}

    //[TestMethod]
    //public void TrialSubscription_SecondarySubscriptionKey_Matches()
    //{
    //  var value = Config.SecondarySubscriptionKey;

    //  Assert.AreEqual(value, TrialSecondarySubscriptionKey);
    //}
  }
}
