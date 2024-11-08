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
namespace BunnyApiClient.Compute.Script.Item.Releases
{
    /// <summary>
    /// Builds and executes requests for operations under \compute\script\{id}\releases
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReleasesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReleasesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compute/script/{id}/releases?page={page}&perPage={perPage}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReleasesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compute/script/{id}/releases?page={page}&perPage={perPage}", rawUrl)
        {
        }
        /// <summary>
        /// [ListComputeScriptReleases API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_getreleases)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesGetResponse?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder.ReleasesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesGetResponse> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder.ReleasesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesGetResponse>(requestInfo, global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [ListComputeScriptReleases API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_getreleases)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder.ReleasesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder.ReleasesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Compute.Script.Item.Releases.ReleasesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [ListComputeScriptReleases API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_getreleases)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReleasesRequestBuilderGetQueryParameters 
        {
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
        }
    }
}
#pragma warning restore CS0618
