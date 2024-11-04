namespace bunny_sdk;

using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

using BunnyApiClient;
using EdgeStorageApiClient;
using LoggingApiClient;
using StreamApiClient;

public static class BunnySdk
{
  public class CreateBunnyApiClientParameters
  {
    public CreateBunnyApiClientParameters() { }
    public required string AccessKey { get; set; }
  }
  public static BunnyApiClient CreateBunnyApiClient(CreateBunnyApiClientParameters options)
  {
    var authProvider = new ApiKeyAuthenticationProvider(options.AccessKey, "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header);
    var adapter = new HttpClientRequestAdapter(authProvider);
    return new BunnyApiClient(adapter);
  }
  public class CreateEdgeStorageApiClientParameters
  {
    public CreateEdgeStorageApiClientParameters() { }
    public required string AccessKey { get; set; }
    public required string BaseUrl { get; set; }
  }
  public static EdgeStorageApiClient CreateEdgeStorageApiClient(CreateEdgeStorageApiClientParameters options)
  {
    var authProvider = new ApiKeyAuthenticationProvider(options.AccessKey, "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header);
    var adapter = new HttpClientRequestAdapter(authProvider)
    {
      BaseUrl = options.BaseUrl,
    };
    return new EdgeStorageApiClient(adapter);
  }
  public class CreateLoggingApiClientParameters
  {
    public CreateLoggingApiClientParameters() { }
    public required string AccessKey { get; set; }
  }
  public static LoggingApiClient CreateLoggingApiClient(CreateLoggingApiClientParameters options)
  {
    var authProvider = new ApiKeyAuthenticationProvider(options.AccessKey, "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header);
    var adapter = new HttpClientRequestAdapter(authProvider);
    return new LoggingApiClient(adapter);
  }
  public class CreateStreamApiClientParameters
  {
    public CreateStreamApiClientParameters() { }
    public required string AccessKey { get; set; }
  }
  public static StreamApiClient CreateStreamApiClient(CreateStreamApiClientParameters options)
  {
    var authProvider = new ApiKeyAuthenticationProvider(options.AccessKey, "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header);
    var adapter = new HttpClientRequestAdapter(authProvider);
    return new StreamApiClient(adapter);
  }

}
