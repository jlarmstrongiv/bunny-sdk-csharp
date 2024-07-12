// <auto-generated/>
using BunnyApiClient.Pullzone.Item.Optimizer.Statistics;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Pullzone.Item.Optimizer
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\optimizer
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class OptimizerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The statistics property</summary>
        public global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder Statistics
        {
            get => new global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Optimizer.OptimizerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptimizerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/optimizer", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Optimizer.OptimizerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptimizerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pullzone/{%2Did}/optimizer", rawUrl)
        {
        }
    }
}
