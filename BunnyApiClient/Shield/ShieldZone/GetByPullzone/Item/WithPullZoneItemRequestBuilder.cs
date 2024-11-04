// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.Shield;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \shield\shield-zone\get-by-pullzone\{pullZoneId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithPullZoneItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item.WithPullZoneItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPullZoneItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/shield/shield-zone/get-by-pullzone/{pullZoneId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item.WithPullZoneItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPullZoneItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/shield/shield-zone/get-by-pullzone/{pullZoneId}", rawUrl)
        {
        }
        /// <returns>A <see cref="global::BunnyApiClient.Models.Shield.GetShieldZoneResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::BunnyApiClient.Models.Shield.ProblemDetails">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.Shield.GetShieldZoneResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.Shield.GetShieldZoneResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::BunnyApiClient.Models.Shield.ProblemDetails.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.Shield.GetShieldZoneResponse>(requestInfo, global::BunnyApiClient.Models.Shield.GetShieldZoneResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item.WithPullZoneItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item.WithPullZoneItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Shield.ShieldZone.GetByPullzone.Item.WithPullZoneItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
