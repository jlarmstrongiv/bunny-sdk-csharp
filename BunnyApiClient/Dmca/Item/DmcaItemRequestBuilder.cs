// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Dmca.Item.Resolve;
using BunnyApiClient.Models.AbuseCases;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Dmca.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \dmca\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DmcaItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The resolve property</summary>
        public global::BunnyApiClient.Dmca.Item.Resolve.ResolveRequestBuilder Resolve
        {
            get => new global::BunnyApiClient.Dmca.Item.Resolve.ResolveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DmcaItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dmca/{id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DmcaItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dmca/{id}", rawUrl)
        {
        }
        /// <summary>
        /// [GetDmcaCase API Docs](https://docs.bunny.net/reference/abusecasepublic_getabusecase)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.AbuseCases.AbuseCase"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.AbuseCases.AbuseCase?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.AbuseCases.AbuseCase> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.AbuseCases.AbuseCase>(requestInfo, global::BunnyApiClient.Models.AbuseCases.AbuseCase.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetDmcaCase API Docs](https://docs.bunny.net/reference/abusecasepublic_getabusecase)
        /// </summary>
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
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
