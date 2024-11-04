// <auto-generated/>
#pragma warning disable CS0618
using LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace LoggingApiClient.WithMmWithDdWithYy
{
    /// <summary>
    /// Builds and executes requests for operations under \{mm}-{dd}-{yy}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithMmWithDdWithYyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="dd">The path parameter: dd</param>
        /// <param name="mm">The path parameter: mm</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="yy">The path parameter: yy</param>
        public WithMmWithDdWithYyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string dd = "", string mm = "", string yy = "") : base(requestAdapter, "{+baseurl}/{mm}-{dd}-{yy}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(dd)) PathParameters.Add("dd", dd);
            if (!string.IsNullOrWhiteSpace(mm)) PathParameters.Add("mm", mm);
            if (!string.IsNullOrWhiteSpace(yy)) PathParameters.Add("yy", yy);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMmWithDdWithYyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{mm}-{dd}-{yy}", rawUrl)
        {
        }
        /// <summary>
        /// Builds and executes requests for operations under \{mm}-{dd}-{yy}\{pullZoneId}.log
        /// </summary>
        /// <returns>A <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder"/></returns>
        /// <param name="pullZoneId">The path parameter: pullZoneId</param>
        public global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder WithPullZoneIdLog(long? pullZoneId)
        {
            _ = pullZoneId ?? throw new ArgumentNullException(nameof(pullZoneId));
            return new global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder(PathParameters, RequestAdapter, pullZoneId);
        }
    }
}
#pragma warning restore CS0618
