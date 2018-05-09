// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A reference to an Azure Virtual Machines Marketplace image or the Azure
    /// Image resource of a custom Virtual Machine. To get the list of all
    /// imageReferences verified by Azure Batch, see the 'List supported node
    /// agent SKUs' operation.
    /// </summary>
    public partial class ImageReference
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        /// <param name="publisher">The publisher of the Azure Virtual Machines
        /// Marketplace image.</param>
        /// <param name="offer">The offer type of the Azure Virtual Machines
        /// Marketplace image.</param>
        /// <param name="sku">The SKU of the Azure Virtual Machines Marketplace
        /// image.</param>
        /// <param name="version">The version of the Azure Virtual Machines
        /// Marketplace image.</param>
        /// <param name="id">The ARM resource identifier of the virtual machine
        /// image. Computes nodes of the pool will be created using this custom
        /// image. This is of the form
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}</param>
        public ImageReference(string publisher = default(string), string offer = default(string), string sku = default(string), string version = default(string), string id = default(string))
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the publisher of the Azure Virtual Machines
        /// Marketplace image.
        /// </summary>
        /// <remarks>
        /// For example, Canonical or MicrosoftWindowsServer.
        /// </remarks>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the offer type of the Azure Virtual Machines
        /// Marketplace image.
        /// </summary>
        /// <remarks>
        /// For example, UbuntuServer or WindowsServer.
        /// </remarks>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the Azure Virtual Machines Marketplace
        /// image.
        /// </summary>
        /// <remarks>
        /// For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </remarks>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the version of the Azure Virtual Machines Marketplace
        /// image.
        /// </summary>
        /// <remarks>
        /// A value of 'latest' can be specified to select the latest version
        /// of an image. If omitted, the default is 'latest'.
        /// </remarks>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual machine
        /// image. Computes nodes of the pool will be created using this custom
        /// image. This is of the form
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}
        /// </summary>
        /// <remarks>
        /// This property is mutually exclusive with other properties. The
        /// virtual machine image must be in the same region and subscription
        /// as the Azure Batch account. For information about the firewall
        /// settings for Batch node agent to communicate with Batch service see
        /// https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration
        /// .
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}