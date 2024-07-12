// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Models.ManageVideos;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Item.Repackage
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\repackage
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class RepackageRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepackageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/repackage?keepOriginalFiles={keepOriginalFiles}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepackageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/repackage?keepOriginalFiles={keepOriginalFiles}", rawUrl)
        {
        }
        /// <summary>
        /// [RepackageVideo API Docs](https://docs.bunny.net/reference/video_repackage)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.Video"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.ManageVideos.Video?> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder.RepackageRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.ManageVideos.Video> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder.RepackageRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.ManageVideos.Video>(requestInfo, global::StreamApiClient.Models.ManageVideos.Video.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [RepackageVideo API Docs](https://docs.bunny.net/reference/video_repackage)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder.RepackageRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder.RepackageRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [RepackageVideo API Docs](https://docs.bunny.net/reference/video_repackage)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class RepackageRequestBuilderPostQueryParameters 
        {
            /// <summary>Marks whether previous file versions should be kept in storage, allows for faster repackage later on. Default is true.</summary>
            [QueryParameter("keepOriginalFiles")]
            public bool? KeepOriginalFiles { get; set; }
        }
    }
}
