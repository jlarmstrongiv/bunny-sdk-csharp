// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Library.Item.Videos.Fetch;
using StreamApiClient.Library.Item.Videos.Item;
using StreamApiClient.Models.ManageVideos;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class VideosRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fetch property</summary>
        public global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder Fetch
        {
            get => new global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the StreamApiClient.library.item.videos.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/></returns>
        public global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("videoId", position);
                return new global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VideosRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos?itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&collection,search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VideosRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos?itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&collection,search}", rawUrl)
        {
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.VideosGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Library.Item.Videos.VideosGetResponse?> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Library.Item.Videos.VideosGetResponse> GetAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Library.Item.Videos.VideosGetResponse>(requestInfo, global::StreamApiClient.Library.Item.Videos.VideosGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [CreateVideo API Docs](https://docs.bunny.net/reference/video_createvideo)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.Video"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageVideos.Video?> PostAsync(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageVideos.Video> PostAsync(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageVideos.Video>(requestInfo, global::StreamApiClient.Models.ManageVideos.Video.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [CreateVideo API Docs](https://docs.bunny.net/reference/video_createvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/videos", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VideosRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("collection")]
            public string? Collection { get; set; }
#nullable restore
#else
            [QueryParameter("collection")]
            public string Collection { get; set; }
#endif
            [QueryParameter("itemsPerPage")]
            public int? ItemsPerPage { get; set; }
            [QueryParameter("orderBy")]
            public global::StreamApiClient.Library.Item.Videos.GetOrderByQueryParameterType? OrderBy { get; set; }
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
#pragma warning restore CS0618
