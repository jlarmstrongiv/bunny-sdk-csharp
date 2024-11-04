// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using StreamApiClient.Library.Item.Videos.Item.Captions.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace StreamApiClient.Library.Item.Videos.Item.Captions
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\captions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CaptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the StreamApiClient.library.item.videos.item.captions.item collection</summary>
        /// <param name="position">srclang specified as a path parameter</param>
        /// <returns>A <see cref="global::StreamApiClient.Library.Item.Videos.Item.Captions.Item.WithSrclangPathParameterItemRequestBuilder"/></returns>
        public global::StreamApiClient.Library.Item.Videos.Item.Captions.Item.WithSrclangPathParameterItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("srclangPathParameter", position);
                return new global::StreamApiClient.Library.Item.Videos.Item.Captions.Item.WithSrclangPathParameterItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CaptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/captions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CaptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/library/{libraryId}/videos/{videoId}/captions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
