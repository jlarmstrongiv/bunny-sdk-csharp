// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\resolutions\cleanup
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CleanupRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CleanupRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/resolutions/cleanup{?deleteMp4Files,deleteNonConfiguredResolutions,deleteOriginal,resolutionsToDelete}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CleanupRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/resolutions/cleanup{?deleteMp4Files,deleteNonConfiguredResolutions,deleteOriginal,resolutionsToDelete}", rawUrl)
        {
        }
        /// <summary>
        /// [CleanupUnconfiguredResolutions API Docs](https://docs.bunny.net/reference/video_deleteresolutions)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsResult?> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder.CleanupRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsResult> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder.CleanupRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsResult>(requestInfo, global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsResult.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [CleanupUnconfiguredResolutions API Docs](https://docs.bunny.net/reference/video_deleteresolutions)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder.CleanupRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder.CleanupRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Videos.Item.Resolutions.Cleanup.CleanupRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [CleanupUnconfiguredResolutions API Docs](https://docs.bunny.net/reference/video_deleteresolutions)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CleanupRequestBuilderPostQueryParameters 
        {
            [QueryParameter("deleteMp4Files")]
            public bool? DeleteMp4Files { get; set; }
            [QueryParameter("deleteNonConfiguredResolutions")]
            public bool? DeleteNonConfiguredResolutions { get; set; }
            [QueryParameter("deleteOriginal")]
            public bool? DeleteOriginal { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("resolutionsToDelete")]
            public string? ResolutionsToDelete { get; set; }
#nullable restore
#else
            [QueryParameter("resolutionsToDelete")]
            public string ResolutionsToDelete { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
