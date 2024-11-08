// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Item.Transcribe
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\transcribe
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TranscribeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TranscribeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/transcribe?force={force}&language={language}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TranscribeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/transcribe?force={force}&language={language}", rawUrl)
        {
        }
        /// <summary>
        /// [TranscribeVideo API Docs](https://docs.bunny.net/reference/video_transcribevideo)
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.StructuredSuccessResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse?> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder.TranscribeRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::StreamApiClient.Models.StructuredSuccessResponse> PostAsync(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder.TranscribeRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::StreamApiClient.Models.StructuredSuccessResponse>(requestInfo, global::StreamApiClient.Models.StructuredSuccessResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [TranscribeVideo API Docs](https://docs.bunny.net/reference/video_transcribevideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder.TranscribeRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder.TranscribeRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [TranscribeVideo API Docs](https://docs.bunny.net/reference/video_transcribevideo)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TranscribeRequestBuilderPostQueryParameters 
        {
            [QueryParameter("force")]
            public bool? Force { get; set; }
            /// <summary>Video source language, use ISO 639-1 language code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("language")]
            public string? Language { get; set; }
#nullable restore
#else
            [QueryParameter("language")]
            public string Language { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
