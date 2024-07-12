// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Models.ManageCollections;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Collections.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\collections\{collectionId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class WithCollectionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCollectionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/collections/{collectionId}?includeThumbnails={includeThumbnails}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCollectionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/collections/{collectionId}?includeThumbnails={includeThumbnails}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteCollection API Docs](https://docs.bunny.net/reference/collection_deletecollection)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.StructuredSuccessResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.StructuredSuccessResponse>(requestInfo, global::StreamApiClient.Models.StructuredSuccessResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageCollections.Collection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageCollections.Collection?> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageCollections.Collection> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageCollections.Collection>(requestInfo, global::StreamApiClient.Models.ManageCollections.Collection.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [UpdateCollection API Docs](https://docs.bunny.net/reference/collection_updatecollection)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.StructuredSuccessResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse?> PostAsync(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse> PostAsync(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.StructuredSuccessResponse>(requestInfo, global::StreamApiClient.Models.StructuredSuccessResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [DeleteCollection API Docs](https://docs.bunny.net/reference/collection_deletecollection)
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/library/{libraryId}/collections/{collectionId}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateCollection API Docs](https://docs.bunny.net/reference/collection_updatecollection)
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
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/collections/{collectionId}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class WithCollectionItemRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeThumbnails")]
            public bool? IncludeThumbnails { get; set; }
        }
    }
}
