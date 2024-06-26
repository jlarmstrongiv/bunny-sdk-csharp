// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Videolibrary.ResetApiKey
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\resetApiKey
    /// </summary>
    public class ResetApiKeyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResetApiKeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/videolibrary/resetApiKey?id={id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResetApiKeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/videolibrary/resetApiKey?id={id}", rawUrl)
        {
        }
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        public class ResetApiKeyRequestBuilderPostQueryParameters 
        {
            /// <summary>The ID of the Video Library that should have the password reset</summary>
            [QueryParameter("id")]
            public long? Id { get; set; }
        }
    }
}
