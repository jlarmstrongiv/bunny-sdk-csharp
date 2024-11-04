// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.PullZone
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BunnyAiImageBlueprint_Properties : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Cfg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cfg { get; set; }
#nullable restore
#else
        public string Cfg { get; set; }
#endif
        /// <summary>The NegativePrompt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NegativePrompt { get; set; }
#nullable restore
#else
        public string NegativePrompt { get; set; }
#endif
        /// <summary>The PostPrompt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostPrompt { get; set; }
#nullable restore
#else
        public string PostPrompt { get; set; }
#endif
        /// <summary>The PrePrompt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrePrompt { get; set; }
#nullable restore
#else
        public string PrePrompt { get; set; }
#endif
        /// <summary>The Steps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Steps { get; set; }
#nullable restore
#else
        public string Steps { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.PullZone.BunnyAiImageBlueprint_Properties"/> and sets the default values.
        /// </summary>
        public BunnyAiImageBlueprint_Properties()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.PullZone.BunnyAiImageBlueprint_Properties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.PullZone.BunnyAiImageBlueprint_Properties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.PullZone.BunnyAiImageBlueprint_Properties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Cfg", n => { Cfg = n.GetStringValue(); } },
                { "NegativePrompt", n => { NegativePrompt = n.GetStringValue(); } },
                { "PostPrompt", n => { PostPrompt = n.GetStringValue(); } },
                { "PrePrompt", n => { PrePrompt = n.GetStringValue(); } },
                { "Steps", n => { Steps = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Cfg", Cfg);
            writer.WriteStringValue("NegativePrompt", NegativePrompt);
            writer.WriteStringValue("PostPrompt", PostPrompt);
            writer.WriteStringValue("PrePrompt", PrePrompt);
            writer.WriteStringValue("Steps", Steps);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
