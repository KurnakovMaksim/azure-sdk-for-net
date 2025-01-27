// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServerAzureADOnlyAuthentication data model. </summary>
    public partial class ServerAzureADOnlyAuthenticationData : ResourceData
    {
        /// <summary> Initializes a new instance of ServerAzureADOnlyAuthenticationData. </summary>
        public ServerAzureADOnlyAuthenticationData()
        {
        }

        /// <summary> Initializes a new instance of ServerAzureADOnlyAuthenticationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azureADOnlyAuthentication"> Azure Active Directory only Authentication enabled. </param>
        internal ServerAzureADOnlyAuthenticationData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, bool? azureADOnlyAuthentication) : base(id, name, type, systemData)
        {
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
        }

        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? AzureADOnlyAuthentication { get; set; }
    }
}
