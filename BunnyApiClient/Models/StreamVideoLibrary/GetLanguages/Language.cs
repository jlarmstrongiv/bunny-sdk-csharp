// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BunnyApiClient.Models.StreamVideoLibrary.GetLanguages
{
    #pragma warning disable CS1591
    public class Language : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ShortCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortCode { get; set; }
#nullable restore
#else
        public string ShortCode { get; set; }
#endif
        /// <summary>The SupportPlayerTranslation property</summary>
        public bool? SupportPlayerTranslation { get; set; }
        /// <summary>The SupportTranscribing property</summary>
        public bool? SupportTranscribing { get; set; }
        /// <summary>The TranscribingAccuracy property</summary>
        public int? TranscribingAccuracy { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Models.StreamVideoLibrary.GetLanguages.Language"/> and sets the default values.
        /// </summary>
        public Language()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Models.StreamVideoLibrary.GetLanguages.Language"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.StreamVideoLibrary.GetLanguages.Language CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.StreamVideoLibrary.GetLanguages.Language();
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
                { "ShortCode", n => { ShortCode = n.GetStringValue(); } },
                { "SupportPlayerTranslation", n => { SupportPlayerTranslation = n.GetBoolValue(); } },
                { "SupportTranscribing", n => { SupportTranscribing = n.GetBoolValue(); } },
                { "TranscribingAccuracy", n => { TranscribingAccuracy = n.GetIntValue(); } },
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
            writer.WriteStringValue("ShortCode", ShortCode);
            writer.WriteBoolValue("SupportPlayerTranslation", SupportPlayerTranslation);
            writer.WriteBoolValue("SupportTranscribing", SupportTranscribing);
            writer.WriteIntValue("TranscribingAccuracy", TranscribingAccuracy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
