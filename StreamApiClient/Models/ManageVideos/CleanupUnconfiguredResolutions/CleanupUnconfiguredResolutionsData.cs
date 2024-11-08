// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CleanupUnconfiguredResolutionsData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The availableResolutionsAfter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableResolutionsAfter { get; set; }
#nullable restore
#else
        public List<string> AvailableResolutionsAfter { get; set; }
#endif
        /// <summary>The deletedOriginal property</summary>
        public bool? DeletedOriginal { get; set; }
        /// <summary>The deletedStorageObjects property</summary>
        public bool? DeletedStorageObjects { get; set; }
        /// <summary>The modifiedPlaylist property</summary>
        public bool? ModifiedPlaylist { get; set; }
        /// <summary>The resolutionsToDelete property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResolutionsToDelete { get; set; }
#nullable restore
#else
        public List<string> ResolutionsToDelete { get; set; }
#endif
        /// <summary>The resolutionsToDeleteFromMp4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResolutionsToDeleteFromMp4 { get; set; }
#nullable restore
#else
        public List<string> ResolutionsToDeleteFromMp4 { get; set; }
#endif
        /// <summary>The resolutionsToDeleteFromPlaylist property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResolutionsToDeleteFromPlaylist { get; set; }
#nullable restore
#else
        public List<string> ResolutionsToDeleteFromPlaylist { get; set; }
#endif
        /// <summary>The resolutionsToDeleteFromStorage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResolutionsToDeleteFromStorage { get; set; }
#nullable restore
#else
        public List<string> ResolutionsToDeleteFromStorage { get; set; }
#endif
        /// <summary>The storageObjectsToDelete property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StorageObjectsToDelete { get; set; }
#nullable restore
#else
        public List<string> StorageObjectsToDelete { get; set; }
#endif
        /// <summary>The updatedAvailableResolutions property</summary>
        public bool? UpdatedAvailableResolutions { get; set; }
        /// <summary>The videoId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoId { get; set; }
#nullable restore
#else
        public string VideoId { get; set; }
#endif
        /// <summary>The videoLibraryId property</summary>
        public long? VideoLibraryId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsData"/> and sets the default values.
        /// </summary>
        public CleanupUnconfiguredResolutionsData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::StreamApiClient.Models.ManageVideos.CleanupUnconfiguredResolutions.CleanupUnconfiguredResolutionsData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availableResolutionsAfter", n => { AvailableResolutionsAfter = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "deletedOriginal", n => { DeletedOriginal = n.GetBoolValue(); } },
                { "deletedStorageObjects", n => { DeletedStorageObjects = n.GetBoolValue(); } },
                { "modifiedPlaylist", n => { ModifiedPlaylist = n.GetBoolValue(); } },
                { "resolutionsToDelete", n => { ResolutionsToDelete = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "resolutionsToDeleteFromMp4", n => { ResolutionsToDeleteFromMp4 = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "resolutionsToDeleteFromPlaylist", n => { ResolutionsToDeleteFromPlaylist = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "resolutionsToDeleteFromStorage", n => { ResolutionsToDeleteFromStorage = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "storageObjectsToDelete", n => { StorageObjectsToDelete = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "updatedAvailableResolutions", n => { UpdatedAvailableResolutions = n.GetBoolValue(); } },
                { "videoId", n => { VideoId = n.GetStringValue(); } },
                { "videoLibraryId", n => { VideoLibraryId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("availableResolutionsAfter", AvailableResolutionsAfter);
            writer.WriteBoolValue("deletedOriginal", DeletedOriginal);
            writer.WriteBoolValue("deletedStorageObjects", DeletedStorageObjects);
            writer.WriteBoolValue("modifiedPlaylist", ModifiedPlaylist);
            writer.WriteCollectionOfPrimitiveValues<string>("resolutionsToDelete", ResolutionsToDelete);
            writer.WriteCollectionOfPrimitiveValues<string>("resolutionsToDeleteFromMp4", ResolutionsToDeleteFromMp4);
            writer.WriteCollectionOfPrimitiveValues<string>("resolutionsToDeleteFromPlaylist", ResolutionsToDeleteFromPlaylist);
            writer.WriteCollectionOfPrimitiveValues<string>("resolutionsToDeleteFromStorage", ResolutionsToDeleteFromStorage);
            writer.WriteCollectionOfPrimitiveValues<string>("storageObjectsToDelete", StorageObjectsToDelete);
            writer.WriteBoolValue("updatedAvailableResolutions", UpdatedAvailableResolutions);
            writer.WriteStringValue("videoId", VideoId);
            writer.WriteLongValue("videoLibraryId", VideoLibraryId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
