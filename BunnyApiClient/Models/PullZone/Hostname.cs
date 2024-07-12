// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.PullZone
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Hostname : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains the Base64Url encoded certificate for the hostname</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate { get; set; }
#nullable restore
#else
        public string Certificate { get; set; }
#endif
        /// <summary>Contains the Base64Url encoded certificate key for the hostname</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateKey { get; set; }
#nullable restore
#else
        public string CertificateKey { get; set; }
#endif
        /// <summary>Determines if the Force SSL feature is enabled</summary>
        public bool? ForceSSL { get; set; }
        /// <summary>Determines if the hostname has an SSL certificate configured</summary>
        public bool? HasCertificate { get; set; }
        /// <summary>The unique ID of the hostname</summary>
        public long? Id { get; set; }
        /// <summary>Determines if this is a system hostname controlled by bunny.net</summary>
        public bool? IsSystemHostname { get; set; }
        /// <summary>The hostname value for the domain name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.PullZone.Hostname"/> and sets the default values.
        /// </summary>
        public Hostname()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.PullZone.Hostname"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.PullZone.Hostname CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.PullZone.Hostname();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Certificate", n => { Certificate = n.GetStringValue(); } },
                { "CertificateKey", n => { CertificateKey = n.GetStringValue(); } },
                { "ForceSSL", n => { ForceSSL = n.GetBoolValue(); } },
                { "HasCertificate", n => { HasCertificate = n.GetBoolValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "IsSystemHostname", n => { IsSystemHostname = n.GetBoolValue(); } },
                { "Value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Certificate", Certificate);
            writer.WriteStringValue("CertificateKey", CertificateKey);
            writer.WriteBoolValue("ForceSSL", ForceSSL);
            writer.WriteBoolValue("HasCertificate", HasCertificate);
            writer.WriteLongValue("Id", Id);
            writer.WriteBoolValue("IsSystemHostname", IsSystemHostname);
            writer.WriteStringValue("Value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
