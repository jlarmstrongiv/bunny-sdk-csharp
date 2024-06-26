// <auto-generated/>
using BunnyApiClient.Models.StreamVideoLibrary;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BunnyApiClient.Videolibrary
{
    #pragma warning disable CS1591
    public class VideolibraryPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the Video Library.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The geo-replication regions of the underlying storage zone</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.StreamVideoLibrary.ReplicationRegions?>? ReplicationRegions { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.StreamVideoLibrary.ReplicationRegions?> ReplicationRegions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Videolibrary.VideolibraryPostRequestBody"/> and sets the default values.
        /// </summary>
        public VideolibraryPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Videolibrary.VideolibraryPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Name", n => { Name = n.GetStringValue(); } },
                { "ReplicationRegions", n => { ReplicationRegions = n.GetCollectionOfEnumValues<global::BunnyApiClient.Models.StreamVideoLibrary.ReplicationRegions>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Name", Name);
            writer.WriteCollectionOfEnumValues<global::BunnyApiClient.Models.StreamVideoLibrary.ReplicationRegions>("ReplicationRegions", ReplicationRegions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}