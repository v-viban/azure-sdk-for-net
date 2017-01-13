// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using Azure;
    using Management;
    using Relay;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of WcfRelays Resource.
    /// </summary>
    [JsonTransformation]
    public partial class WcfRelaysResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WcfRelaysResource class.
        /// </summary>
        public WcfRelaysResource() { }

        /// <summary>
        /// Initializes a new instance of the WcfRelaysResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="type">Resource type. Possible values include:
        /// 'Microsoft.Relay/WcfRelays'</param>
        /// <param name="path">The path of the relay.</param>
        /// <param name="relayType">Relay NameSpace Type. Possible values
        /// include: 'NetTcp', 'Http'</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="listenerCount">The number of listeners for this relay.
        /// min : 1 and max:25 supported</param>
        /// <param name="requiresClientAuthorization">true if client
        /// authorization is needed for this relay; otherwise, false.</param>
        /// <param name="requiresTransportSecurity">true if transport security
        /// is needed for this relay; otherwise, false.</param>
        /// <param name="isDynamic">true if the relay is dynamic; otherwise,
        /// false.</param>
        /// <param name="userMetadata">usermetadata is a placeholder to store
        /// user-defined string data for the HybridConnection endpoint.e.g. it
        /// can be used to store  descriptive data, such as list of teams and
        /// their contact information also user-defined configuration settings
        /// can be stored.</param>
        /// <param name="collectionName">The name of the collection associated
        /// with the relay.</param>
        public WcfRelaysResource(string location, string id = default(string), string name = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), WcfRelaysResourceType? type = default(WcfRelaysResourceType?), string path = default(string), Relaytype? relayType = default(Relaytype?), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), int? listenerCount = default(int?), bool? requiresClientAuthorization = default(bool?), AuthorizationRules authorizationRules = default(AuthorizationRules), bool? requiresTransportSecurity = default(bool?), bool? isDynamic = default(bool?), string userMetadata = default(string), string collectionName = default(string))
            : base(location, id, name, tags)
        {
            Type = type;
            Path = path;
            RelayType = relayType;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ListenerCount = listenerCount;
            RequiresClientAuthorization = requiresClientAuthorization;
            AuthorizationRules = authorizationRules;
            RequiresTransportSecurity = requiresTransportSecurity;
            IsDynamic = isDynamic;
            UserMetadata = userMetadata;
            CollectionName = collectionName;
        }

        /// <summary>
        /// Gets or sets resource type. Possible values include:
        /// 'Microsoft.Relay/WcfRelays'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public WcfRelaysResourceType? Type { get; set; }

        /// <summary>
        /// Gets or sets the path of the relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets relay NameSpace Type. Possible values include:
        /// 'NetTcp', 'Http'
        /// </summary>
        [JsonProperty(PropertyName = "properties.relayType")]
        public Relaytype? RelayType { get; set; }

        /// <summary>
        /// Gets the time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; protected set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; protected set; }

        /// <summary>
        /// Gets or sets the number of listeners for this relay. min : 1 and
        /// max:25 supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.listenerCount")]
        public int? ListenerCount { get; set; }

        /// <summary>
        /// Gets or sets true if client authorization is needed for this relay;
        /// otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresClientAuthorization")]
        public bool? RequiresClientAuthorization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationRules")]
        public AuthorizationRules AuthorizationRules { get; set; }

        /// <summary>
        /// Gets or sets true if transport security is needed for this relay;
        /// otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresTransportSecurity")]
        public bool? RequiresTransportSecurity { get; set; }

        /// <summary>
        /// Gets or sets true if the relay is dynamic; otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// Gets or sets usermetadata is a placeholder to store user-defined
        /// string data for the HybridConnection endpoint.e.g. it can be used
        /// to store  descriptive data, such as list of teams and their contact
        /// information also user-defined configuration settings can be stored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userMetadata")]
        public string UserMetadata { get; set; }

        /// <summary>
        /// Gets or sets the name of the collection associated with the relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collectionName")]
        public string CollectionName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

