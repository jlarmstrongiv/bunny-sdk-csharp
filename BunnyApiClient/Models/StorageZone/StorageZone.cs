// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.PullZone;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.StorageZone
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class StorageZone : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Custom404FilePath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Custom404FilePath { get; set; }
#nullable restore
#else
        public string Custom404FilePath { get; set; }
#endif
        /// <summary>The DateModified property</summary>
        public DateTimeOffset? DateModified { get; private set; }
        /// <summary>The Deleted property</summary>
        public bool? Deleted { get; private set; }
        /// <summary>The Discount property</summary>
        public int? Discount { get; private set; }
        /// <summary>The FilesStored property</summary>
        public long? FilesStored { get; private set; }
        /// <summary>The Id property</summary>
        public long? Id { get; private set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; private set; }
#nullable restore
#else
        public string Password { get; private set; }
#endif
        /// <summary>The PriceOverride property</summary>
        public double? PriceOverride { get; private set; }
        /// <summary>The PullZones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.PullZone.PullZone>? PullZones { get; private set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.PullZone.PullZone> PullZones { get; private set; }
#endif
        /// <summary>The ReadOnlyPassword property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReadOnlyPassword { get; private set; }
#nullable restore
#else
        public string ReadOnlyPassword { get; private set; }
#endif
        /// <summary>The Region property</summary>
        public global::BunnyApiClient.Models.StorageZone.StandardRegions? Region { get; set; }
        /// <summary>The ReplicationChangeInProgress property</summary>
        public bool? ReplicationChangeInProgress { get; private set; }
        /// <summary>The ReplicationRegions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.StorageZone.EdgeReplicationRegions?>? ReplicationRegions { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.StorageZone.EdgeReplicationRegions?> ReplicationRegions { get; set; }
#endif
        /// <summary>The Rewrite404To200 property</summary>
        public bool? Rewrite404To200 { get; set; }
        /// <summary>The StorageHostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageHostname { get; private set; }
#nullable restore
#else
        public string StorageHostname { get; private set; }
#endif
        /// <summary>The StorageUsed property</summary>
        public long? StorageUsed { get; private set; }
        /// <summary>The UserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; private set; }
#nullable restore
#else
        public string UserId { get; private set; }
#endif
        /// <summary>The ZoneTier property</summary>
        public double? ZoneTier { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.StorageZone.StorageZone"/> and sets the default values.
        /// </summary>
        public StorageZone()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.StorageZone.StorageZone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.StorageZone.StorageZone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.StorageZone.StorageZone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Custom404FilePath", n => { Custom404FilePath = n.GetStringValue(); } },
                { "DateModified", n => { DateModified = n.GetDateTimeOffsetValue(); } },
                { "Deleted", n => { Deleted = n.GetBoolValue(); } },
                { "Discount", n => { Discount = n.GetIntValue(); } },
                { "FilesStored", n => { FilesStored = n.GetLongValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Password", n => { Password = n.GetStringValue(); } },
                { "PriceOverride", n => { PriceOverride = n.GetDoubleValue(); } },
                { "PullZones", n => { PullZones = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.PullZone>(global::BunnyApiClient.Models.PullZone.PullZone.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ReadOnlyPassword", n => { ReadOnlyPassword = n.GetStringValue(); } },
                { "Region", n => { Region = n.GetEnumValue<global::BunnyApiClient.Models.StorageZone.StandardRegions>(); } },
                { "ReplicationChangeInProgress", n => { ReplicationChangeInProgress = n.GetBoolValue(); } },
                { "ReplicationRegions", n => { ReplicationRegions = n.GetCollectionOfEnumValues<global::BunnyApiClient.Models.StorageZone.EdgeReplicationRegions>()?.AsList(); } },
                { "Rewrite404To200", n => { Rewrite404To200 = n.GetBoolValue(); } },
                { "StorageHostname", n => { StorageHostname = n.GetStringValue(); } },
                { "StorageUsed", n => { StorageUsed = n.GetLongValue(); } },
                { "UserId", n => { UserId = n.GetStringValue(); } },
                { "ZoneTier", n => { ZoneTier = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Custom404FilePath", Custom404FilePath);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<global::BunnyApiClient.Models.StorageZone.StandardRegions>("Region", Region);
            writer.WriteCollectionOfEnumValues<global::BunnyApiClient.Models.StorageZone.EdgeReplicationRegions>("ReplicationRegions", ReplicationRegions);
            writer.WriteBoolValue("Rewrite404To200", Rewrite404To200);
            writer.WriteDoubleValue("ZoneTier", ZoneTier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
