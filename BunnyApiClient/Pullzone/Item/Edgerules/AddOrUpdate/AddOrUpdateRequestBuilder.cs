// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.PullZone.EdgeRule;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\edgerules\addOrUpdate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AddOrUpdateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddOrUpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/edgerules/addOrUpdate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddOrUpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/edgerules/addOrUpdate", rawUrl)
        {
        }
        /// <summary>
        /// [AddUpdateEdgeRule API Docs](https://docs.bunny.net/reference/pullzonepublic_addedgerule)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule?> PostAsync(global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule> PostAsync(global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule>(requestInfo, global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [AddUpdateEdgeRule API Docs](https://docs.bunny.net/reference/pullzonepublic_addedgerule)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
