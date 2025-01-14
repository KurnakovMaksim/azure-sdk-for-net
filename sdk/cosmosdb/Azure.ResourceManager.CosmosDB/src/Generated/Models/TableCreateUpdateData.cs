// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB Table. </summary>
    public partial class TableCreateUpdateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of TableCreateUpdateData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public TableCreateUpdateData(AzureLocation location, TableResource resource) : base(location)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of TableCreateUpdateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Table. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        internal TableCreateUpdateData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, TableResource resource, CreateUpdateOptions options) : base(id, name, type, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> The standard JSON format of a Table. </summary>
        internal TableResource Resource { get; set; }
        /// <summary> Name of the Cosmos DB table. </summary>
        public string ResourceId
        {
            get => Resource is null ? default : Resource.Id;
            set => Resource = new TableResource(value);
        }

        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CreateUpdateOptions Options { get; set; }
    }
}
