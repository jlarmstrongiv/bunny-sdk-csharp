// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Library.Item.Collections.Item;
using StreamApiClient.Models.ManageCollections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Collections
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\collections
    /// </summary>
    public class CollectionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the StreamApiClient.library.item.collections.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/></returns>
        public global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("collectionId", position);
                return new global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollectionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/collections?includeThumbnails={includeThumbnails}&itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollectionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/collections?includeThumbnails={includeThumbnails}&itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&search*}", rawUrl)
        {
        }
        /// <summary>
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Library.Item.Collections.CollectionsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Library.Item.Collections.CollectionsGetResponse?> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Library.Item.Collections.CollectionsGetResponse> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Library.Item.Collections.CollectionsGetResponse>(requestInfo, global::StreamApiClient.Library.Item.Collections.CollectionsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [CreateCollection API Docs](https://docs.bunny.net/reference/collection_createcollection)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Models.ManageCollections.Collection"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageCollections.Collection?> PostAsync(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageCollections.Collection> PostAsync(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageCollections.Collection>(requestInfo, global::StreamApiClient.Models.ManageCollections.Collection.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [CreateCollection API Docs](https://docs.bunny.net/reference/collection_createcollection)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/collections", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        public class CollectionsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeThumbnails")]
            public bool? IncludeThumbnails { get; set; }
            [QueryParameter("itemsPerPage")]
            public int? ItemsPerPage { get; set; }
            [QueryParameter("orderBy")]
            public global::StreamApiClient.Library.Item.Collections.GetOrderByQueryParameterType? OrderBy { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
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
