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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sku of the Namespace.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of this Sku. Possible values include:
        /// 'Basic', 'Standard', 'Premium'</param>
        public Sku(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Static constructor for Sku class.
        /// </summary>
        static Sku()
        {
            Tier = "Standard";
        }

        /// <summary>
        /// Gets or sets name of this Sku. Possible values include: 'Basic',
        /// 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The tier of this particular SKU
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public static string Tier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
