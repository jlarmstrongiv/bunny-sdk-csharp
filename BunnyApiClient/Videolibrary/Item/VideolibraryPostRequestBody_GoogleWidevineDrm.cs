// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Videolibrary.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class VideolibraryPostRequestBody_GoogleWidevineDrm : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CertificateExpirationDate property</summary>
        public DateTimeOffset? CertificateExpirationDate { get; set; }
        /// <summary>The CertificateId property</summary>
        public long? CertificateId { get; set; }
        /// <summary>The Enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The MinClientSecurityLevel property</summary>
        public double? MinClientSecurityLevel { get; set; }
        /// <summary>The Provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The SdOnlyForL3 property</summary>
        public bool? SdOnlyForL3 { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody_GoogleWidevineDrm"/> and sets the default values.
        /// </summary>
        public VideolibraryPostRequestBody_GoogleWidevineDrm()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody_GoogleWidevineDrm"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody_GoogleWidevineDrm CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody_GoogleWidevineDrm();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CertificateExpirationDate", n => { CertificateExpirationDate = n.GetDateTimeOffsetValue(); } },
                { "CertificateId", n => { CertificateId = n.GetLongValue(); } },
                { "Enabled", n => { Enabled = n.GetBoolValue(); } },
                { "MinClientSecurityLevel", n => { MinClientSecurityLevel = n.GetDoubleValue(); } },
                { "Provider", n => { Provider = n.GetStringValue(); } },
                { "SdOnlyForL3", n => { SdOnlyForL3 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("CertificateExpirationDate", CertificateExpirationDate);
            writer.WriteLongValue("CertificateId", CertificateId);
            writer.WriteBoolValue("Enabled", Enabled);
            writer.WriteDoubleValue("MinClientSecurityLevel", MinClientSecurityLevel);
            writer.WriteStringValue("Provider", Provider);
            writer.WriteBoolValue("SdOnlyForL3", SdOnlyForL3);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
