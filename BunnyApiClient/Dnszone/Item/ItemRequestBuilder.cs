// <auto-generated/>
using BunnyApiClient.Dnszone.Item.Dismissnameservercheck;
using BunnyApiClient.Dnszone.Item.Export;
using BunnyApiClient.Dnszone.Item.Import;
using BunnyApiClient.Dnszone.Item.Recheckdns;
using BunnyApiClient.Dnszone.Item.Records;
using BunnyApiClient.Dnszone.Item.Statistics;
using BunnyApiClient.Models.DnsZone;
using BunnyApiClient.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Dnszone.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \dnszone\{-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The dismissnameservercheck property</summary>
        public global::BunnyApiClient.Dnszone.Item.Dismissnameservercheck.DismissnameservercheckRequestBuilder Dismissnameservercheck
        {
            get => new global::BunnyApiClient.Dnszone.Item.Dismissnameservercheck.DismissnameservercheckRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The export property</summary>
        public global::BunnyApiClient.Dnszone.Item.Export.ExportRequestBuilder Export
        {
            get => new global::BunnyApiClient.Dnszone.Item.Export.ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The import property</summary>
        public global::BunnyApiClient.Dnszone.Item.Import.ImportRequestBuilder Import
        {
            get => new global::BunnyApiClient.Dnszone.Item.Import.ImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The recheckdns property</summary>
        public global::BunnyApiClient.Dnszone.Item.Recheckdns.RecheckdnsRequestBuilder Recheckdns
        {
            get => new global::BunnyApiClient.Dnszone.Item.Recheckdns.RecheckdnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The records property</summary>
        public global::BunnyApiClient.Dnszone.Item.Records.RecordsRequestBuilder Records
        {
            get => new global::BunnyApiClient.Dnszone.Item.Records.RecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statistics property</summary>
        public global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsRequestBuilder Statistics
        {
            get => new global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dnszone/{%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dnszone/{%2Did}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_delete)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::BunnyApiClient.Models.StructuredBadRequestResponse">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::BunnyApiClient.Models.StructuredBadRequestResponse.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_index2)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.DnsZone.DnsZone"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.DnsZone.DnsZone?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.DnsZone.DnsZone> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.DnsZone.DnsZone>(requestInfo, global::BunnyApiClient.Models.DnsZone.DnsZone.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [UpdateDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_update)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.DnsZone.DnsZone"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.DnsZone.DnsZone?> PostAsync(global::BunnyApiClient.Dnszone.Item.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.DnsZone.DnsZone> PostAsync(global::BunnyApiClient.Dnszone.Item.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.DnsZone.DnsZone>(requestInfo, global::BunnyApiClient.Models.DnsZone.DnsZone.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [DeleteDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_delete)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_index2)
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
        /// [UpdateDnsZone API Docs](https://docs.bunny.net/reference/dnszonepublic_update)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Dnszone.Item.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Dnszone.Item.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::BunnyApiClient.Dnszone.Item.ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Dnszone.Item.ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Dnszone.Item.ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
