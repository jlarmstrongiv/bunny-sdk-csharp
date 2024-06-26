// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BunnyApiClient.Models.PullZone.EdgeRule
{
    #pragma warning disable CS1591
    public class EdgeRule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Action parameter 1. The value depends on other parameters of the edge rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionParameter1 { get; set; }
#nullable restore
#else
        public string ActionParameter1 { get; set; }
#endif
        /// <summary>The Action parameter 2. The value depends on other parameters of the edge rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionParameter2 { get; set; }
#nullable restore
#else
        public string ActionParameter2 { get; set; }
#endif
        /// <summary>The ActionType property</summary>
        public double? ActionType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the edge rule</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Determines if the edge rule is currently enabled or not</summary>
        public bool? Enabled { get; set; }
        /// <summary>The ExtraActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.PullZone.EdgeRule.ActionObject>? ExtraActions { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.PullZone.EdgeRule.ActionObject> ExtraActions { get; set; }
#endif
        /// <summary>The unique GUID of the edge rule</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Guid { get; set; }
#nullable restore
#else
        public string Guid { get; set; }
#endif
        /// <summary>The TriggerMatchingType property</summary>
        public double? TriggerMatchingType { get; set; }
        /// <summary>The Triggers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger>? Triggers { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger> Triggers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule"/> and sets the default values.
        /// </summary>
        public EdgeRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.PullZone.EdgeRule.EdgeRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ActionParameter1", n => { ActionParameter1 = n.GetStringValue(); } },
                { "ActionParameter2", n => { ActionParameter2 = n.GetStringValue(); } },
                { "ActionType", n => { ActionType = n.GetDoubleValue(); } },
                { "Description", n => { Description = n.GetStringValue(); } },
                { "Enabled", n => { Enabled = n.GetBoolValue(); } },
                { "ExtraActions", n => { ExtraActions = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.EdgeRule.ActionObject>(global::BunnyApiClient.Models.PullZone.EdgeRule.ActionObject.CreateFromDiscriminatorValue)?.ToList(); } },
                { "Guid", n => { Guid = n.GetStringValue(); } },
                { "TriggerMatchingType", n => { TriggerMatchingType = n.GetDoubleValue(); } },
                { "Triggers", n => { Triggers = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger>(global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ActionParameter1", ActionParameter1);
            writer.WriteStringValue("ActionParameter2", ActionParameter2);
            writer.WriteDoubleValue("ActionType", ActionType);
            writer.WriteStringValue("Description", Description);
            writer.WriteBoolValue("Enabled", Enabled);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.EdgeRule.ActionObject>("ExtraActions", ExtraActions);
            writer.WriteStringValue("Guid", Guid);
            writer.WriteDoubleValue("TriggerMatchingType", TriggerMatchingType);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger>("Triggers", Triggers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}