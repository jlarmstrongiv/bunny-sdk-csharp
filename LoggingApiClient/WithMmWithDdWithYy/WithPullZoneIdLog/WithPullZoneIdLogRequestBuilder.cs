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
namespace LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog
{
    /// <summary>
    /// Builds and executes requests for operations under \{mm}-{dd}-{yy}\{pullZoneId}.log
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithPullZoneIdLogRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="pullZoneId">The path parameter: pullZoneId</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPullZoneIdLogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, long? pullZoneId = default) : base(requestAdapter, "{+baseurl}/{mm}-{dd}-{yy}/{pullZoneId}.log?end={end}&order={order}&search={search}&start={start}&status={status}", pathParameters)
        {
            if (pullZoneId != null) PathParameters.Add("pullZoneId", pullZoneId);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPullZoneIdLogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{mm}-{dd}-{yy}/{pullZoneId}.log?end={end}&order={order}&search={search}&start={start}&status={status}", rawUrl)
        {
        }
        /// <summary>
        /// [LoggingApi API Docs](https://docs.bunny.net/docs/cdn-logging-api)
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder.WithPullZoneIdLogRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder.WithPullZoneIdLogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [LoggingApi API Docs](https://docs.bunny.net/docs/cdn-logging-api)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder.WithPullZoneIdLogRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder.WithPullZoneIdLogRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/gzip");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder WithUrl(string rawUrl)
        {
            return new global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [LoggingApi API Docs](https://docs.bunny.net/docs/cdn-logging-api)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPullZoneIdLogRequestBuilderGetQueryParameters 
        {
            [QueryParameter("end")]
            public long? End { get; set; }
            [QueryParameter("order")]
            public global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.GetOrderQueryParameterType? Order { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
            [QueryParameter("start")]
            public long? Start { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public string? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public string Status { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
