// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The AvailableScopeProperties. </summary>
    public partial class AvailableScopeProperties
    {
        /// <summary> Initializes a new instance of AvailableScopeProperties. </summary>
        internal AvailableScopeProperties()
        {
        }

        /// <summary> Initializes a new instance of AvailableScopeProperties. </summary>
        /// <param name="properties"></param>
        internal AvailableScopeProperties(SubscriptionScopeProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Gets the properties. </summary>
        internal SubscriptionScopeProperties Properties { get; }
        /// <summary> Gets the scopes. </summary>
        public IReadOnlyList<ScopeProperties> Scopes
        {
            get => Properties.Scopes;
        }
    }
}
