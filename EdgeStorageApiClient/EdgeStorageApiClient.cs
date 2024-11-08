// <auto-generated/>
#pragma warning disable CS0618
using EdgeStorageApiClient.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace EdgeStorageApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EdgeStorageApiClient : BaseRequestBuilder
    {
        /// <summary>Gets an item from the EdgeStorageApiClient.item collection</summary>
        /// <param name="position">the name of your storage zone where you are connecting to.</param>
        /// <returns>A <see cref="global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder"/></returns>
        public global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("storageZoneName", position);
                return new global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::EdgeStorageApiClient.EdgeStorageApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdgeStorageApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://{region}.bunnycdn.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
        /// <summary>
        /// Builds and executes requests for operations under \{storageZoneName}\
        /// </summary>
        /// <returns>A <see cref="global::EdgeStorageApiClient.Item.WithStorageZoneNameSlashRequestBuilder"/></returns>
        /// <param name="storageZoneName">The name of your storage zone where you are connecting to.</param>
        public global::EdgeStorageApiClient.Item.WithStorageZoneNameSlashRequestBuilder WithStorageZoneNameSlash(string storageZoneName)
        {
            if(string.IsNullOrEmpty(storageZoneName)) throw new ArgumentNullException(nameof(storageZoneName));
            return new global::EdgeStorageApiClient.Item.WithStorageZoneNameSlashRequestBuilder(PathParameters, RequestAdapter, storageZoneName);
        }
    }
}
#pragma warning restore CS0618
