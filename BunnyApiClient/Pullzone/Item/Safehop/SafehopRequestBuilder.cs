// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Pullzone.Item.Safehop.Statistics;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Pullzone.Item.Safehop
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\safehop
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SafehopRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The statistics property</summary>
        public global::BunnyApiClient.Pullzone.Item.Safehop.Statistics.StatisticsRequestBuilder Statistics
        {
            get => new global::BunnyApiClient.Pullzone.Item.Safehop.Statistics.StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Safehop.SafehopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SafehopRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/safehop", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Safehop.SafehopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SafehopRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/safehop", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
