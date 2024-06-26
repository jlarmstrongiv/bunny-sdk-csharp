// <auto-generated/>
using LoggingApiClient.WithMmWithDdWithYy;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace LoggingApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class LoggingApiClient : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="LoggingApiClient.LoggingApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoggingApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://logging.bunnycdn.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
        /// <summary>
        /// Builds and executes requests for operations under \{mm}-{dd}-{yy}
        /// </summary>
        /// <returns>A <see cref="LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder"/></returns>
        /// <param name="dd">The path parameter: dd</param>
        /// <param name="mm">The path parameter: mm</param>
        /// <param name="yy">The path parameter: yy</param>
        public global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder WithMmWithDdWithYy(int? dd, int? mm, int? yy)
        {
            _ = dd ?? throw new ArgumentNullException(nameof(dd));
            _ = mm ?? throw new ArgumentNullException(nameof(mm));
            _ = yy ?? throw new ArgumentNullException(nameof(yy));
            return new global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder(PathParameters, RequestAdapter, dd, mm, yy);
        }
    }
}
