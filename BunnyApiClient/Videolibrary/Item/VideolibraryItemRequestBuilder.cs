// <auto-generated/>
using BunnyApiClient.Models.StreamVideoLibrary;
using BunnyApiClient.Videolibrary.Item.AddAllowedReferrer;
using BunnyApiClient.Videolibrary.Item.AddBlockedReferrer;
using BunnyApiClient.Videolibrary.Item.RemoveAllowedReferrer;
using BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer;
using BunnyApiClient.Videolibrary.Item.ResetApiKey;
using BunnyApiClient.Videolibrary.Item.Watermark;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Videolibrary.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class VideolibraryItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The addAllowedReferrer property</summary>
        public global::BunnyApiClient.Videolibrary.Item.AddAllowedReferrer.AddAllowedReferrerRequestBuilder AddAllowedReferrer
        {
            get => new global::BunnyApiClient.Videolibrary.Item.AddAllowedReferrer.AddAllowedReferrerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The addBlockedReferrer property</summary>
        public global::BunnyApiClient.Videolibrary.Item.AddBlockedReferrer.AddBlockedReferrerRequestBuilder AddBlockedReferrer
        {
            get => new global::BunnyApiClient.Videolibrary.Item.AddBlockedReferrer.AddBlockedReferrerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The removeAllowedReferrer property</summary>
        public global::BunnyApiClient.Videolibrary.Item.RemoveAllowedReferrer.RemoveAllowedReferrerRequestBuilder RemoveAllowedReferrer
        {
            get => new global::BunnyApiClient.Videolibrary.Item.RemoveAllowedReferrer.RemoveAllowedReferrerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The removeBlockedReferrer property</summary>
        public global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerRequestBuilder RemoveBlockedReferrer
        {
            get => new global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetApiKey property</summary>
        public global::BunnyApiClient.Videolibrary.Item.ResetApiKey.ResetApiKeyRequestBuilder ResetApiKey
        {
            get => new global::BunnyApiClient.Videolibrary.Item.ResetApiKey.ResetApiKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The watermark property</summary>
        public global::BunnyApiClient.Videolibrary.Item.Watermark.WatermarkRequestBuilder Watermark
        {
            get => new global::BunnyApiClient.Videolibrary.Item.Watermark.WatermarkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VideolibraryItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/videolibrary/{id}?includeAccessKey={includeAccessKey}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VideolibraryItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/videolibrary/{id}?includeAccessKey={includeAccessKey}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_delete)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary>(requestInfo, global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [UpdateVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_update)
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary?> PostAsync(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary> PostAsync(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary>(requestInfo, global::BunnyApiClient.Models.StreamVideoLibrary.VideoLibrary.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [DeleteVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_delete)
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/videolibrary/{id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_update)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/videolibrary/{id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class VideolibraryItemRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeAccessKey")]
            public bool? IncludeAccessKey { get; set; }
        }
    }
}
