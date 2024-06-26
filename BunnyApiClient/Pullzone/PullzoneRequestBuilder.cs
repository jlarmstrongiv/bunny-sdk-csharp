// <auto-generated/>
using BunnyApiClient.Models.PullZone;
using BunnyApiClient.Pullzone.Checkavailability;
using BunnyApiClient.Pullzone.Item;
using BunnyApiClient.Pullzone.LoadFreeCertificate;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Pullzone
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone
    /// </summary>
    public class PullzoneRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The checkavailability property</summary>
        public global::BunnyApiClient.Pullzone.Checkavailability.CheckavailabilityRequestBuilder Checkavailability
        {
            get => new global::BunnyApiClient.Pullzone.Checkavailability.CheckavailabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The loadFreeCertificate property</summary>
        public global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder LoadFreeCertificate
        {
            get => new global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the BunnyApiClient.pullzone.item collection</summary>
        /// <param name="position">The ID of the Pull Zone that should be returned</param>
        /// <returns>A <see cref="BunnyApiClient.Pullzone.Item.ItemRequestBuilder"/></returns>
        public global::BunnyApiClient.Pullzone.Item.ItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new global::BunnyApiClient.Pullzone.Item.ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.PullzoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PullzoneRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone?includeCertificate={includeCertificate}&page={page}&perPage={perPage}{&search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.PullzoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PullzoneRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone?includeCertificate={includeCertificate}&page={page}&perPage={perPage}{&search*}", rawUrl)
        {
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Pullzone.PullzoneGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Pullzone.PullzoneGetResponse?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Pullzone.PullzoneGetResponse> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Pullzone.PullzoneGetResponse>(requestInfo, global::BunnyApiClient.Pullzone.PullzoneGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [AddPullZone API Docs](https://docs.bunny.net/reference/pullzonepublic_add)
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Models.PullZone.PullZone"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.PullZone.PullZone?> PostAsync(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.PullZone.PullZone> PostAsync(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.PullZone.PullZone>(requestInfo, global::BunnyApiClient.Models.PullZone.PullZone.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [AddPullZone API Docs](https://docs.bunny.net/reference/pullzonepublic_add)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/pullzone", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Pullzone.PullzoneRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Pullzone.PullzoneRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Pullzone.PullzoneRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        public class PullzoneRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines if the result hostnames should contain the SSL certificate</summary>
            [QueryParameter("includeCertificate")]
            public bool? IncludeCertificate { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
            /// <summary>The search term that will be used to filter the results</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
    }
}