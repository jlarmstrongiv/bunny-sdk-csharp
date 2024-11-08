// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Dnszone.Item.Import
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ImportPostResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The RecordsFailed property</summary>
        public int? RecordsFailed { get; set; }
        /// <summary>The RecordsSkipped property</summary>
        public int? RecordsSkipped { get; set; }
        /// <summary>The RecordsSuccessful property</summary>
        public int? RecordsSuccessful { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.Import.ImportPostResponse"/> and sets the default values.
        /// </summary>
        public ImportPostResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Dnszone.Item.Import.ImportPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Dnszone.Item.Import.ImportPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Dnszone.Item.Import.ImportPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "RecordsFailed", n => { RecordsFailed = n.GetIntValue(); } },
                { "RecordsSkipped", n => { RecordsSkipped = n.GetIntValue(); } },
                { "RecordsSuccessful", n => { RecordsSuccessful = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("RecordsFailed", RecordsFailed);
            writer.WriteIntValue("RecordsSkipped", RecordsSkipped);
            writer.WriteIntValue("RecordsSuccessful", RecordsSuccessful);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
