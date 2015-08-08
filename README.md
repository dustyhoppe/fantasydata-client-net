# FantasyData .NET Client
.NET client wrapper for the FantasyData API


___

##NuGet Installation

From Visual Studio, open your NuGet Package Manager Console and type one of the following commands based on the API you are intending to use.

#####NFL API
```
PM> Install-Package FantasyData.NFL
```

#####MLB API
```
PM> Install-Package FantasyData.MLB
```

## usage
In order to begin using the FantasyData client library, you must start by configuring your application with your FantasyData.com API keys. If you don't have these, you can start by logging into your [fantasydata.com](http://fantasydata.com) account and locating the API keys under the **subscriptions** tab.

Once you have your API keys, you'll need to update your application's config file ( App.config or Web.config ). Add a new **section** element to the **configSections** element as follows.

```xml
  <configSections>
    <section name="fantasyData" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData"/>
  </configSections>
```

Next, you'll need to add a **fantasyData** section to your config file.

```xml
<fantasyData defaultSubscription="NFL">
    <subscriptions>
      <add name="NFL" baseUrl="http://api.nfldata.apiphany.com/nfl/v2/" primarySubscriptionKey="***primarySubscriptionKey***" secondarySubscriptionKey="***secondarySubscriptionKey***"/>
      <add name="MLB" baseUrl="http://api.nfldata.apiphany.com/mlb/v2/" primarySubscriptionKey="***primarySubscriptionKey***" secondarySubscriptionKey="***secondarySubscriptionKey***"/>
    </subscriptions>
</fantasyData>
```

You'll need at least the one subscription under the subscriptions element. 

**Note: Make sure the defaultSubscription attribute of value correlates with the subscription you're intending the application to use.**

