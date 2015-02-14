using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers;

namespace FantasyData
{
  public class FantasyDataApiBase
  {
    private const string XML = "XML";
    private const string JSON = "JSON";

    #region Properties and Accessors

    protected string BaseUrl { get; private set; }
    protected bool UseJSON { get; private set; }
    protected string PrimarySubscriptionKey { get; private set; }
    protected string SecondarySubscriptionKey { get; private set; }

    private static string _userAgent;

    private static string UserAgent
    {
      get
      {
        if (_userAgent == null)
        {
          _userAgent = String.Format("FantasyData.NET RestSharp Client v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
        return _userAgent;
      }
    }

    private RestClient _client;

    #endregion

    #region Constructors

    public FantasyDataApiBase(string baseUrl, string primarySubscriptionKey)
    {
      if (string.IsNullOrEmpty(primarySubscriptionKey))
        throw new ArgumentException("Primary Subscription Key is required.");

      if (string.IsNullOrEmpty(baseUrl))
        throw new ArgumentException("Api Base Url is required.");

      PrimarySubscriptionKey = primarySubscriptionKey;

      if (baseUrl.EndsWith("/"))
        baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);

      BaseUrl = baseUrl;
      UseJSON = false;

      _client = new RestClient();
      _client.UserAgent = UserAgent;
      _client.BaseUrl = Config.ApiBaseUrl;
    }


    public FantasyDataApiBase(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey, bool useJSON)
      : this(baseUrl, primarySubscriptionKey)
    {
      UseJSON = useJSON;
      SecondarySubscriptionKey = secondarySubscriptionKey;
    }

    #endregion

    public T GetRequest<T>(string path, params object[] args) where T : new()
    {
      return GetRequest<T>(path, string.Empty, args);
    }

    public T GetRequest<T>(string path, string rootElement, params object[] args) where T : new()
    {
      RestRequest request = new RestRequest(BuildUrl(path, args));
      if (!string.IsNullOrWhiteSpace(rootElement)) request.RootElement = rootElement;
      InitializeRequest(request);

      var response = _client.Execute<T>(request);

      if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
      {
        throw new FantasyDataException("Not Found");
      }
      else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
      {
        throw new FantasyDataException("Internal Server Error");
      }

      return response.Data;
    }


    public string BuildUrl(string path, params object[] args)
    {
      var formatPart = string.Format("/{0}", (UseJSON ? JSON : XML));

      return formatPart + string.Format(path, args) + string.Format("{0}subscription-key",(args.Length == 0 ? '?' : '&')) + GetSubscriptionKey();
    }


    public void InitializeRequest(RestRequest request)
    {
      if (request.Resource.ToLowerInvariant().Contains("xml"))
      {
        request.RequestFormat = DataFormat.Xml;
        request.XmlSerializer = new RestSharp.Serializers.DotNetXmlSerializer();
      }
      else
      {
        request.RequestFormat = DataFormat.Json;
        request.JsonSerializer = new JsonSerializer();
      }
    }

    public string GetSubscriptionKey()
    {
      if (!string.IsNullOrEmpty(PrimarySubscriptionKey))
        return PrimarySubscriptionKey;
      else if (!string.IsNullOrEmpty(SecondarySubscriptionKey))
        return SecondarySubscriptionKey;

      throw new FantasyDataException("No subscription key set.");
    }
  }
}
