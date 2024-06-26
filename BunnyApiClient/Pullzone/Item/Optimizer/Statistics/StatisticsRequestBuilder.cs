// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Pullzone.Item.Optimizer.Statistics
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\optimizer\statistics
    /// </summary>
    public class StatisticsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatisticsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/optimizer/statistics{?dateFrom*,dateTo*,hourly*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatisticsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/optimizer/statistics{?dateFrom*,dateTo*,hourly*}", rawUrl)
        {
        }
        /// <summary>
        /// [GetOptimizerStatistics API Docs](https://docs.bunny.net/reference/pullzonepublic_optimizerstatistics)
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsGetResponse?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsGetResponse> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsGetResponse>(requestInfo, global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetOptimizerStatistics API Docs](https://docs.bunny.net/reference/pullzonepublic_optimizerstatistics)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [GetOptimizerStatistics API Docs](https://docs.bunny.net/reference/pullzonepublic_optimizerstatistics)
        /// </summary>
        public class StatisticsRequestBuilderGetQueryParameters 
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
        }
    }
}
