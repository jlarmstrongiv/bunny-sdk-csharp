// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BunnyApiClient.Pullzone.Item.AddCertificate
{
    #pragma warning disable CS1591
    public class AddCertificatePostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Base64Url encoded binary data of the certificate file</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate { get; set; }
#nullable restore
#else
        public string Certificate { get; set; }
#endif
        /// <summary>The Base64Url encoded binary data of the certificate key file</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateKey { get; set; }
#nullable restore
#else
        public string CertificateKey { get; set; }
#endif
        /// <summary>The hostname to which the certificate will be added</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.AddCertificate.AddCertificatePostRequestBody"/> and sets the default values.
        /// </summary>
        public AddCertificatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Pullzone.Item.AddCertificate.AddCertificatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Pullzone.Item.AddCertificate.AddCertificatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Pullzone.Item.AddCertificate.AddCertificatePostRequestBody();
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
                { "Hostname", n => { Hostname = n.GetStringValue(); } },
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
            writer.WriteStringValue("Hostname", Hostname);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}