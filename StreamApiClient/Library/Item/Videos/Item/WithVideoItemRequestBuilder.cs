// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Library.Item.Videos.Item.Captions;
using StreamApiClient.Library.Item.Videos.Item.Heatmap;
using StreamApiClient.Library.Item.Videos.Item.Play;
using StreamApiClient.Library.Item.Videos.Item.Reencode;
using StreamApiClient.Library.Item.Videos.Item.Repackage;
using StreamApiClient.Library.Item.Videos.Item.Thumbnail;
using StreamApiClient.Library.Item.Videos.Item.Transcribe;
using StreamApiClient.Models.ManageVideos;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}
    /// </summary>
    public class WithVideoItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The captions property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder Captions
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The heatmap property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Heatmap.HeatmapRequestBuilder Heatmap
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Heatmap.HeatmapRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The play property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Play.PlayRequestBuilder Play
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Play.PlayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reencode property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Reencode.ReencodeRequestBuilder Reencode
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Reencode.ReencodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repackage property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder Repackage
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The thumbnail property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder Thumbnail
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transcribe property</summary>
        public global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder Transcribe
        {
            get => new global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithVideoItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}{?enabledResolutions*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithVideoItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}{?enabledResolutions*}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteVideo API Docs](https://docs.bunny.net/reference/video_deletevideo)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Models.StructuredSuccessResponse"/></returns>
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
        /// [GetVideo API Docs](https://docs.bunny.net/reference/video_getvideo)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Models.ManageVideos.Video"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageVideos.Video?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageVideos.Video> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageVideos.Video>(requestInfo, global::StreamApiClient.Models.ManageVideos.Video.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [UpdateVideo API Docs](https://docs.bunny.net/reference/video_updatevideo)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Models.StructuredSuccessResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse?> PostAsync(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse> PostAsync(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.StructuredSuccessResponse>(requestInfo, global::StreamApiClient.Models.StructuredSuccessResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Models.StructuredSuccessResponse"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse?> PutAsync(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse> PutAsync(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.StructuredSuccessResponse>(requestInfo, global::StreamApiClient.Models.StructuredSuccessResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [DeleteVideo API Docs](https://docs.bunny.net/reference/video_deletevideo)
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
        /// [GetVideo API Docs](https://docs.bunny.net/reference/video_getvideo)
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
        /// [UpdateVideo API Docs](https://docs.bunny.net/reference/video_updatevideo)
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
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        public class WithVideoItemRequestBuilderPutQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enabledResolutions")]
            public string? EnabledResolutions { get; set; }
#nullable restore
#else
            [QueryParameter("enabledResolutions")]
            public string EnabledResolutions { get; set; }
#endif
        }
    }
}
