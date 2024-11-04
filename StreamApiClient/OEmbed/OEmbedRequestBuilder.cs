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
namespace StreamApiClient.OEmbed
{
    /// <summary>
    /// Builds and executes requests for operations under \OEmbed
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OEmbedRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.OEmbed.OEmbedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OEmbedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/OEmbed?expires={expires}&url={url}{&maxHeight,maxWidth,token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.OEmbed.OEmbedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OEmbedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/OEmbed?expires={expires}&url={url}{&maxHeight,maxWidth,token}", rawUrl)
        {
        }
        /// <summary>
        /// [OEmbed API Docs](https://docs.bunny.net/reference/oembed_getoembed)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.OEmbed.OEmbedGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.OEmbed.OEmbedGetResponse?> GetAsync(Action<RequestConfiguration<global::StreamApiClient.OEmbed.OEmbedRequestBuilder.OEmbedRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.OEmbed.OEmbedGetResponse> GetAsync(Action<RequestConfiguration<global::StreamApiClient.OEmbed.OEmbedRequestBuilder.OEmbedRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.OEmbed.OEmbedGetResponse>(requestInfo, global::StreamApiClient.OEmbed.OEmbedGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [OEmbed API Docs](https://docs.bunny.net/reference/oembed_getoembed)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.OEmbed.OEmbedRequestBuilder.OEmbedRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.OEmbed.OEmbedRequestBuilder.OEmbedRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::StreamApiClient.OEmbed.OEmbedRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.OEmbed.OEmbedRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.OEmbed.OEmbedRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [OEmbed API Docs](https://docs.bunny.net/reference/oembed_getoembed)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OEmbedRequestBuilderGetQueryParameters 
        {
            [QueryParameter("expires")]
            public long? Expires { get; set; }
            [QueryParameter("maxHeight")]
            public int? MaxHeight { get; set; }
            [QueryParameter("maxWidth")]
            public int? MaxWidth { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("token")]
            public string? Token { get; set; }
#nullable restore
#else
            [QueryParameter("token")]
            public string Token { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("url")]
            public string? Url { get; set; }
#nullable restore
#else
            [QueryParameter("url")]
            public string Url { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
