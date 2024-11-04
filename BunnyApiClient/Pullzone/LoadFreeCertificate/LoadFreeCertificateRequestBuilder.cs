// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Pullzone.LoadFreeCertificate
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\loadFreeCertificate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LoadFreeCertificateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoadFreeCertificateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/loadFreeCertificate?hostname={hostname}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LoadFreeCertificateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/loadFreeCertificate?hostname={hostname}", rawUrl)
        {
        }
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoadFreeCertificateRequestBuilderGetQueryParameters 
        {
            /// <summary>The hostname that the certificate will be loaded for</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("hostname")]
            public string? Hostname { get; set; }
#nullable restore
#else
            [QueryParameter("hostname")]
            public string Hostname { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
