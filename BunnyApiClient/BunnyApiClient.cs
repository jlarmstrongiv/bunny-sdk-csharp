// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Abusecase;
using BunnyApiClient.Apikey;
using BunnyApiClient.Billing;
using BunnyApiClient.Compute;
using BunnyApiClient.Country;
using BunnyApiClient.Dmca;
using BunnyApiClient.Dnszone;
using BunnyApiClient.Pullzone;
using BunnyApiClient.Purge;
using BunnyApiClient.Region;
using BunnyApiClient.Search;
using BunnyApiClient.Statistics;
using BunnyApiClient.Storagezone;
using BunnyApiClient.User;
using BunnyApiClient.Videolibrary;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class BunnyApiClient : BaseRequestBuilder
    {
        /// <summary>The abusecase property</summary>
        public global::BunnyApiClient.Abusecase.AbusecaseRequestBuilder Abusecase
        {
            get => new global::BunnyApiClient.Abusecase.AbusecaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The apikey property</summary>
        public global::BunnyApiClient.Apikey.ApikeyRequestBuilder Apikey
        {
            get => new global::BunnyApiClient.Apikey.ApikeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The billing property</summary>
        public global::BunnyApiClient.Billing.BillingRequestBuilder Billing
        {
            get => new global::BunnyApiClient.Billing.BillingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compute property</summary>
        public global::BunnyApiClient.Compute.ComputeRequestBuilder Compute
        {
            get => new global::BunnyApiClient.Compute.ComputeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The country property</summary>
        public global::BunnyApiClient.Country.CountryRequestBuilder Country
        {
            get => new global::BunnyApiClient.Country.CountryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dmca property</summary>
        public global::BunnyApiClient.Dmca.DmcaRequestBuilder Dmca
        {
            get => new global::BunnyApiClient.Dmca.DmcaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dnszone property</summary>
        public global::BunnyApiClient.Dnszone.DnszoneRequestBuilder Dnszone
        {
            get => new global::BunnyApiClient.Dnszone.DnszoneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pullzone property</summary>
        public global::BunnyApiClient.Pullzone.PullzoneRequestBuilder Pullzone
        {
            get => new global::BunnyApiClient.Pullzone.PullzoneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The purge property</summary>
        public global::BunnyApiClient.Purge.PurgeRequestBuilder Purge
        {
            get => new global::BunnyApiClient.Purge.PurgeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The region property</summary>
        public global::BunnyApiClient.Region.RegionRequestBuilder Region
        {
            get => new global::BunnyApiClient.Region.RegionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public global::BunnyApiClient.Search.SearchRequestBuilder Search
        {
            get => new global::BunnyApiClient.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statistics property</summary>
        public global::BunnyApiClient.Statistics.StatisticsRequestBuilder Statistics
        {
            get => new global::BunnyApiClient.Statistics.StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The storagezone property</summary>
        public global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder Storagezone
        {
            get => new global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::BunnyApiClient.User.UserRequestBuilder User
        {
            get => new global::BunnyApiClient.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The videolibrary property</summary>
        public global::BunnyApiClient.Videolibrary.VideolibraryRequestBuilder Videolibrary
        {
            get => new global::BunnyApiClient.Videolibrary.VideolibraryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.BunnyApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BunnyApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.bunny.net";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
