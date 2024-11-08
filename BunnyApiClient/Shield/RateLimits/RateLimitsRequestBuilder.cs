// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Shield.RateLimits.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Shield.RateLimits
{
    /// <summary>
    /// Builds and executes requests for operations under \shield\rate-limits
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RateLimitsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the BunnyApiClient.shield.rateLimits.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::BunnyApiClient.Shield.RateLimits.Item.WithShieldZoneItemRequestBuilder"/></returns>
        public global::BunnyApiClient.Shield.RateLimits.Item.WithShieldZoneItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("shieldZoneId", position);
                return new global::BunnyApiClient.Shield.RateLimits.Item.WithShieldZoneItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.RateLimits.RateLimitsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RateLimitsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/shield/rate-limits", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.RateLimits.RateLimitsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RateLimitsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/shield/rate-limits", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
