// <auto-generated/>
using BunnyApiClient.Pullzone.Item.Originshield.Queuestatistics;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Pullzone.Item.Originshield
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\originshield
    /// </summary>
    public class OriginshieldRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The queuestatistics property</summary>
        public global::BunnyApiClient.Pullzone.Item.Originshield.Queuestatistics.QueuestatisticsRequestBuilder Queuestatistics
        {
            get => new global::BunnyApiClient.Pullzone.Item.Originshield.Queuestatistics.QueuestatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Originshield.OriginshieldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OriginshieldRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/originshield", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Originshield.OriginshieldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OriginshieldRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/originshield", rawUrl)
        {
        }
    }
}
