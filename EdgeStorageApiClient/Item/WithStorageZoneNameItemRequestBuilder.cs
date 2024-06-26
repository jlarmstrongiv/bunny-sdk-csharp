// <auto-generated/>
using EdgeStorageApiClient.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace EdgeStorageApiClient.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \{storageZoneName}
    /// </summary>
    public class WithStorageZoneNameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the EdgeStorageApiClient.item.item collection</summary>
        /// <param name="position">The directory path that you want to list.</param>
        /// <returns>A <see cref="EdgeStorageApiClient.Item.Item.WithPathItemRequestBuilder"/></returns>
        public global::EdgeStorageApiClient.Item.Item.WithPathItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("path", position);
                return new global::EdgeStorageApiClient.Item.Item.WithPathItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStorageZoneNameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{storageZoneName}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStorageZoneNameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{storageZoneName}", rawUrl)
        {
        }
    }
}
