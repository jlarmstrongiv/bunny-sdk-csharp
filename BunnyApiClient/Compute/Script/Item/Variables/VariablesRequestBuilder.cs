// <auto-generated/>
using BunnyApiClient.Compute.Script.Item.Variables.Add;
using BunnyApiClient.Compute.Script.Item.Variables.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Compute.Script.Item.Variables
{
    /// <summary>
    /// Builds and executes requests for operations under \compute\script\{id}\variables
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class VariablesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The add property</summary>
        public global::BunnyApiClient.Compute.Script.Item.Variables.Add.AddRequestBuilder Add
        {
            get => new global::BunnyApiClient.Compute.Script.Item.Variables.Add.AddRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the BunnyApiClient.compute.script.item.variables.item collection</summary>
        /// <param name="position">The ID of the Environment Variable that will be updated</param>
        /// <returns>A <see cref="global::BunnyApiClient.Compute.Script.Item.Variables.Item.WithVariableItemRequestBuilder"/></returns>
        public global::BunnyApiClient.Compute.Script.Item.Variables.Item.WithVariableItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("variableId", position);
                return new global::BunnyApiClient.Compute.Script.Item.Variables.Item.WithVariableItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Variables.VariablesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VariablesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compute/script/{id}/variables", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Variables.VariablesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VariablesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compute/script/{id}/variables", rawUrl)
        {
        }
    }
}
