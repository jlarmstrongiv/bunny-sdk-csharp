// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.User
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class User : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Id of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The remaining balance on the user&apos;s account</summary>
        public double? Balance { get; set; }
        /// <summary>The email where the invoices and billing messages will be sent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingEmail { get; set; }
#nullable restore
#else
        public string BillingEmail { get; set; }
#endif
        /// <summary>The end date of the account&apos;s free trial. If this is in the past, the free trial has expired.</summary>
        public DateTimeOffset? BillingFreeUntilDate { get; set; }
        /// <summary>The BillingType property</summary>
        public double? BillingType { get; set; }
        /// <summary>The city of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The country name that the user is from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The Alpha2 country code that the user is from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The date when the user joined bunny.net</summary>
        public DateTimeOffset? DateJoined { get; set; }
        /// <summary>Determines if the DPA was accepted by the user or not</summary>
        public bool? DpaAccepted { get; set; }
        /// <summary>Determines the date on which the DPA was accepted</summary>
        public DateTimeOffset? DpaDateAccepted { get; set; }
        /// <summary>Determines which version of the DPA was accepted</summary>
        public int? DpaVersionAccepted { get; set; }
        /// <summary>The email of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Determines if the account&apos;s email has been successfully verified</summary>
        public bool? EmailVerified { get; set; }
        /// <summary>Contains the list of available payment types for this account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledPaymentTypes { get; set; }
#nullable restore
#else
        public List<string> EnabledPaymentTypes { get; set; }
#endif
        /// <summary>The list of features that the user has enabled</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FeatureFlags { get; set; }
#nullable restore
#else
        public List<string> FeatureFlags { get; set; }
#endif
        /// <summary>The first name of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The FreeTrialExtendedDate property</summary>
        public DateTimeOffset? FreeTrialExtendedDate { get; set; }
        /// <summary>The HasCompleteBillingProfile property</summary>
        public bool? HasCompleteBillingProfile { get; set; }
        /// <summary>The Id of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Determines whether the user used a Single Sign On account</summary>
        public bool? IsSsoAccount { get; set; }
        /// <summary>The last name of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Determines if the payments are disabled on this account</summary>
        public bool? PaymentsDisabled { get; set; }
        /// <summary>Determines if the account should receive notification emails from bunny.net</summary>
        public bool? ReceiveNotificationEmails { get; set; }
        /// <summary>Determines if the account should receive promotional emails from bunny.net</summary>
        public bool? ReceivePromotionalEmails { get; set; }
        /// <summary>Determines the roles that the user belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Roles { get; set; }
#nullable restore
#else
        public List<string> Roles { get; set; }
#endif
        /// <summary>The street address of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreetAddress { get; set; }
#nullable restore
#else
        public string StreetAddress { get; set; }
#endif
        /// <summary>Determines if the user&apos;s account is suspended</summary>
        public bool? Suspended { get; set; }
        /// <summary>The total bandwidth used by the account.</summary>
        public long? TotalBandwidthUsed { get; set; }
        /// <summary>The total free trial bandwidth limit for this account</summary>
        public long? TrialBandwidthLimit { get; set; }
        /// <summary>Determines if the account has 2FA enabled</summary>
        public bool? TwoFactorAuthenticationEnabled { get; set; }
        /// <summary>Returns the number of unread tickets on the user&apos;s account</summary>
        public int? UnreadSupportTicketCount { get; set; }
        /// <summary>The billing VAT number of the account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VATNumber { get; set; }
#nullable restore
#else
        public string VATNumber { get; set; }
#endif
        /// <summary>The address zip code of the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZipCode { get; set; }
#nullable restore
#else
        public string ZipCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.User.User"/> and sets the default values.
        /// </summary>
        public User()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.User.User"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.User.User CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.User.User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AccountId", n => { AccountId = n.GetStringValue(); } },
                { "Balance", n => { Balance = n.GetDoubleValue(); } },
                { "BillingEmail", n => { BillingEmail = n.GetStringValue(); } },
                { "BillingFreeUntilDate", n => { BillingFreeUntilDate = n.GetDateTimeOffsetValue(); } },
                { "BillingType", n => { BillingType = n.GetDoubleValue(); } },
                { "City", n => { City = n.GetStringValue(); } },
                { "CompanyName", n => { CompanyName = n.GetStringValue(); } },
                { "Country", n => { Country = n.GetStringValue(); } },
                { "DateJoined", n => { DateJoined = n.GetDateTimeOffsetValue(); } },
                { "DpaAccepted", n => { DpaAccepted = n.GetBoolValue(); } },
                { "DpaDateAccepted", n => { DpaDateAccepted = n.GetDateTimeOffsetValue(); } },
                { "DpaVersionAccepted", n => { DpaVersionAccepted = n.GetIntValue(); } },
                { "Email", n => { Email = n.GetStringValue(); } },
                { "EmailVerified", n => { EmailVerified = n.GetBoolValue(); } },
                { "EnabledPaymentTypes", n => { EnabledPaymentTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "FeatureFlags", n => { FeatureFlags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "FirstName", n => { FirstName = n.GetStringValue(); } },
                { "FreeTrialExtendedDate", n => { FreeTrialExtendedDate = n.GetDateTimeOffsetValue(); } },
                { "HasCompleteBillingProfile", n => { HasCompleteBillingProfile = n.GetBoolValue(); } },
                { "Id", n => { Id = n.GetStringValue(); } },
                { "IsSsoAccount", n => { IsSsoAccount = n.GetBoolValue(); } },
                { "LastName", n => { LastName = n.GetStringValue(); } },
                { "PaymentsDisabled", n => { PaymentsDisabled = n.GetBoolValue(); } },
                { "ReceiveNotificationEmails", n => { ReceiveNotificationEmails = n.GetBoolValue(); } },
                { "ReceivePromotionalEmails", n => { ReceivePromotionalEmails = n.GetBoolValue(); } },
                { "Roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "StreetAddress", n => { StreetAddress = n.GetStringValue(); } },
                { "Suspended", n => { Suspended = n.GetBoolValue(); } },
                { "TotalBandwidthUsed", n => { TotalBandwidthUsed = n.GetLongValue(); } },
                { "TrialBandwidthLimit", n => { TrialBandwidthLimit = n.GetLongValue(); } },
                { "TwoFactorAuthenticationEnabled", n => { TwoFactorAuthenticationEnabled = n.GetBoolValue(); } },
                { "UnreadSupportTicketCount", n => { UnreadSupportTicketCount = n.GetIntValue(); } },
                { "VATNumber", n => { VATNumber = n.GetStringValue(); } },
                { "ZipCode", n => { ZipCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountId", AccountId);
            writer.WriteDoubleValue("Balance", Balance);
            writer.WriteStringValue("BillingEmail", BillingEmail);
            writer.WriteDateTimeOffsetValue("BillingFreeUntilDate", BillingFreeUntilDate);
            writer.WriteDoubleValue("BillingType", BillingType);
            writer.WriteStringValue("City", City);
            writer.WriteStringValue("CompanyName", CompanyName);
            writer.WriteStringValue("Country", Country);
            writer.WriteDateTimeOffsetValue("DateJoined", DateJoined);
            writer.WriteBoolValue("DpaAccepted", DpaAccepted);
            writer.WriteDateTimeOffsetValue("DpaDateAccepted", DpaDateAccepted);
            writer.WriteIntValue("DpaVersionAccepted", DpaVersionAccepted);
            writer.WriteStringValue("Email", Email);
            writer.WriteBoolValue("EmailVerified", EmailVerified);
            writer.WriteCollectionOfPrimitiveValues<string>("EnabledPaymentTypes", EnabledPaymentTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("FeatureFlags", FeatureFlags);
            writer.WriteStringValue("FirstName", FirstName);
            writer.WriteDateTimeOffsetValue("FreeTrialExtendedDate", FreeTrialExtendedDate);
            writer.WriteBoolValue("HasCompleteBillingProfile", HasCompleteBillingProfile);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IsSsoAccount", IsSsoAccount);
            writer.WriteStringValue("LastName", LastName);
            writer.WriteBoolValue("PaymentsDisabled", PaymentsDisabled);
            writer.WriteBoolValue("ReceiveNotificationEmails", ReceiveNotificationEmails);
            writer.WriteBoolValue("ReceivePromotionalEmails", ReceivePromotionalEmails);
            writer.WriteCollectionOfPrimitiveValues<string>("Roles", Roles);
            writer.WriteStringValue("StreetAddress", StreetAddress);
            writer.WriteBoolValue("Suspended", Suspended);
            writer.WriteLongValue("TotalBandwidthUsed", TotalBandwidthUsed);
            writer.WriteLongValue("TrialBandwidthLimit", TrialBandwidthLimit);
            writer.WriteBoolValue("TwoFactorAuthenticationEnabled", TwoFactorAuthenticationEnabled);
            writer.WriteIntValue("UnreadSupportTicketCount", UnreadSupportTicketCount);
            writer.WriteStringValue("VATNumber", VATNumber);
            writer.WriteStringValue("ZipCode", ZipCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
