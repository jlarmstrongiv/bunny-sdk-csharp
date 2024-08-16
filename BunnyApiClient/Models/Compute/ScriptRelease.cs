// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.Compute
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class ScriptRelease : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Author property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Author { get; set; }
#nullable restore
#else
        public string Author { get; set; }
#endif
        /// <summary>The AuthorEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthorEmail { get; set; }
#nullable restore
#else
        public string AuthorEmail { get; set; }
#endif
        /// <summary>The Code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The DatePublished property</summary>
        public DateTimeOffset? DatePublished { get; set; }
        /// <summary>The DateReleased property</summary>
        public DateTimeOffset? DateReleased { get; set; }
        /// <summary>The Deleted property</summary>
        public bool? Deleted { get; set; }
        /// <summary>The Id property</summary>
        public long? Id { get; set; }
        /// <summary>The Note property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The Status property</summary>
        public double? Status { get; set; }
        /// <summary>The Uuid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uuid { get; set; }
#nullable restore
#else
        public string Uuid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Compute.ScriptRelease"/> and sets the default values.
        /// </summary>
        public ScriptRelease()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Compute.ScriptRelease"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Compute.ScriptRelease CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Compute.ScriptRelease();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Author", n => { Author = n.GetStringValue(); } },
                { "AuthorEmail", n => { AuthorEmail = n.GetStringValue(); } },
                { "Code", n => { Code = n.GetStringValue(); } },
                { "DatePublished", n => { DatePublished = n.GetDateTimeOffsetValue(); } },
                { "DateReleased", n => { DateReleased = n.GetDateTimeOffsetValue(); } },
                { "Deleted", n => { Deleted = n.GetBoolValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "Note", n => { Note = n.GetStringValue(); } },
                { "Status", n => { Status = n.GetDoubleValue(); } },
                { "Uuid", n => { Uuid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Author", Author);
            writer.WriteStringValue("AuthorEmail", AuthorEmail);
            writer.WriteStringValue("Code", Code);
            writer.WriteDateTimeOffsetValue("DatePublished", DatePublished);
            writer.WriteDateTimeOffsetValue("DateReleased", DateReleased);
            writer.WriteBoolValue("Deleted", Deleted);
            writer.WriteLongValue("Id", Id);
            writer.WriteStringValue("Note", Note);
            writer.WriteDoubleValue("Status", Status);
            writer.WriteStringValue("Uuid", Uuid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
