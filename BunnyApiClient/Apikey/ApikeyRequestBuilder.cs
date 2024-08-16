// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Apikey
{
    /// <summary>
    /// Builds and executes requests for operations under \apikey
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ApikeyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Apikey.ApikeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApikeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/apikey?page={page}&perPage={perPage}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Apikey.ApikeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApikeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/apikey?page={page}&perPage={perPage}", rawUrl)
        {
        }
        /// <summary>
        /// [ListApiKeys API Docs](https://docs.bunny.net/reference/apikeypublic_listapikeys)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Apikey.ApikeyGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Apikey.ApikeyGetResponse?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Apikey.ApikeyRequestBuilder.ApikeyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Apikey.ApikeyGetResponse> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Apikey.ApikeyRequestBuilder.ApikeyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Apikey.ApikeyGetResponse>(requestInfo, global::BunnyApiClient.Apikey.ApikeyGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [ListApiKeys API Docs](https://docs.bunny.net/reference/apikeypublic_listapikeys)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Apikey.ApikeyRequestBuilder.ApikeyRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Apikey.ApikeyRequestBuilder.ApikeyRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::BunnyApiClient.Apikey.ApikeyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Apikey.ApikeyRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Apikey.ApikeyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [ListApiKeys API Docs](https://docs.bunny.net/reference/apikeypublic_listapikeys)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ApikeyRequestBuilderGetQueryParameters 
        {
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
        }
    }
}
