// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Statistics
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\statistics
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StatisticsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatisticsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/statistics{?dateFrom,dateTo,hourly,videoGuid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatisticsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/statistics{?dateFrom,dateTo,hourly,videoGuid}", rawUrl)
        {
        }
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Statistics.StatisticsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Library.Item.Statistics.StatisticsGetResponse?> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Library.Item.Statistics.StatisticsGetResponse> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Library.Item.Statistics.StatisticsGetResponse>(requestInfo, global::StreamApiClient.Library.Item.Statistics.StatisticsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StatisticsRequestBuilderGetQueryParameters 
        {
            /// <summary>The start date of the statistics. If no value is passed, the last 30 days will be returned.</summary>
            [QueryParameter("dateFrom")]
            public DateTimeOffset? DateFrom { get; set; }
            /// <summary>The end date of the statistics. If no value is passed, the last 30 days will be returned.</summary>
            [QueryParameter("dateTo")]
            public DateTimeOffset? DateTo { get; set; }
            /// <summary>If true, the statistics data will be returned in hourly grouping.</summary>
            [QueryParameter("hourly")]
            public bool? Hourly { get; set; }
            /// <summary>The GUID of the video for which the statistics will be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("videoGuid")]
            public string? VideoGuid { get; set; }
#nullable restore
#else
            [QueryParameter("videoGuid")]
            public string VideoGuid { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
