// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Dnszone.Item.Records
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class RecordsPutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Accelerated property</summary>
        public bool? Accelerated { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The Disabled property</summary>
        public bool? Disabled { get; set; }
        /// <summary>The EnviromentalVariables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody_EnviromentalVariables>? EnviromentalVariables { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody_EnviromentalVariables> EnviromentalVariables { get; set; }
#endif
        /// <summary>The Flags property</summary>
        public int? Flags { get; set; }
        /// <summary>The GeolocationLatitude property</summary>
        public double? GeolocationLatitude { get; set; }
        /// <summary>The GeolocationLongitude property</summary>
        public double? GeolocationLongitude { get; set; }
        /// <summary>The LatencyZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LatencyZone { get; set; }
#nullable restore
#else
        public string LatencyZone { get; set; }
#endif
        /// <summary>The MonitorType property</summary>
        public double? MonitorType { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Port property</summary>
        public int? Port { get; set; }
        /// <summary>The Priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The PullZoneId property</summary>
        public long? PullZoneId { get; set; }
        /// <summary>The ScriptId property</summary>
        public long? ScriptId { get; set; }
        /// <summary>The SmartRoutingType property</summary>
        public double? SmartRoutingType { get; set; }
        /// <summary>The Tag property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tag { get; set; }
#nullable restore
#else
        public string Tag { get; set; }
#endif
        /// <summary>The Ttl property</summary>
        public double? Ttl { get; set; }
        /// <summary>The Type property</summary>
        public double? Type { get; set; }
        /// <summary>The Value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>The Weight property</summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody"/> and sets the default values.
        /// </summary>
        public RecordsPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Accelerated", n => { Accelerated = n.GetBoolValue(); } },
                { "Comment", n => { Comment = n.GetStringValue(); } },
                { "Disabled", n => { Disabled = n.GetBoolValue(); } },
                { "EnviromentalVariables", n => { EnviromentalVariables = n.GetCollectionOfObjectValues<global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody_EnviromentalVariables>(global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody_EnviromentalVariables.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Flags", n => { Flags = n.GetIntValue(); } },
                { "GeolocationLatitude", n => { GeolocationLatitude = n.GetDoubleValue(); } },
                { "GeolocationLongitude", n => { GeolocationLongitude = n.GetDoubleValue(); } },
                { "LatencyZone", n => { LatencyZone = n.GetStringValue(); } },
                { "MonitorType", n => { MonitorType = n.GetDoubleValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Port", n => { Port = n.GetIntValue(); } },
                { "Priority", n => { Priority = n.GetIntValue(); } },
                { "PullZoneId", n => { PullZoneId = n.GetLongValue(); } },
                { "ScriptId", n => { ScriptId = n.GetLongValue(); } },
                { "SmartRoutingType", n => { SmartRoutingType = n.GetDoubleValue(); } },
                { "Tag", n => { Tag = n.GetStringValue(); } },
                { "Ttl", n => { Ttl = n.GetDoubleValue(); } },
                { "Type", n => { Type = n.GetDoubleValue(); } },
                { "Value", n => { Value = n.GetStringValue(); } },
                { "Weight", n => { Weight = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("Accelerated", Accelerated);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteBoolValue("Disabled", Disabled);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Dnszone.Item.Records.RecordsPutRequestBody_EnviromentalVariables>("EnviromentalVariables", EnviromentalVariables);
            writer.WriteIntValue("Flags", Flags);
            writer.WriteDoubleValue("GeolocationLatitude", GeolocationLatitude);
            writer.WriteDoubleValue("GeolocationLongitude", GeolocationLongitude);
            writer.WriteStringValue("LatencyZone", LatencyZone);
            writer.WriteDoubleValue("MonitorType", MonitorType);
            writer.WriteStringValue("Name", Name);
            writer.WriteIntValue("Port", Port);
            writer.WriteIntValue("Priority", Priority);
            writer.WriteLongValue("PullZoneId", PullZoneId);
            writer.WriteLongValue("ScriptId", ScriptId);
            writer.WriteDoubleValue("SmartRoutingType", SmartRoutingType);
            writer.WriteStringValue("Tag", Tag);
            writer.WriteDoubleValue("Ttl", Ttl);
            writer.WriteDoubleValue("Type", Type);
            writer.WriteStringValue("Value", Value);
            writer.WriteIntValue("Weight", Weight);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
