// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Pullzone.Item.Waf.Statistics;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Pullzone.Item.Waf
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\waf
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WafRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The statistics property</summary>
        public global::BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder Statistics
        {
            get => new global::BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WafRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/waf", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WafRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/waf", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
