// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ContainerServiceOrchestratorTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContainerServiceOrchestratorTypes
    {
        [EnumMember(Value = "Kubernetes")]
        Kubernetes,
        [EnumMember(Value = "Swarm")]
        Swarm,
        [EnumMember(Value = "DCOS")]
        DCOS,
        [EnumMember(Value = "DockerCE")]
        DockerCE,
        [EnumMember(Value = "Custom")]
        Custom
    }
    internal static class ContainerServiceOrchestratorTypesEnumExtension
    {
        internal static string ToSerializedValue(this ContainerServiceOrchestratorTypes? value)
        {
            return value == null ? null : ((ContainerServiceOrchestratorTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ContainerServiceOrchestratorTypes value)
        {
            switch( value )
            {
                case ContainerServiceOrchestratorTypes.Kubernetes:
                    return "Kubernetes";
                case ContainerServiceOrchestratorTypes.Swarm:
                    return "Swarm";
                case ContainerServiceOrchestratorTypes.DCOS:
                    return "DCOS";
                case ContainerServiceOrchestratorTypes.DockerCE:
                    return "DockerCE";
                case ContainerServiceOrchestratorTypes.Custom:
                    return "Custom";
            }
            return null;
        }

        internal static ContainerServiceOrchestratorTypes? ParseContainerServiceOrchestratorTypes(this string value)
        {
            switch( value )
            {
                case "Kubernetes":
                    return ContainerServiceOrchestratorTypes.Kubernetes;
                case "Swarm":
                    return ContainerServiceOrchestratorTypes.Swarm;
                case "DCOS":
                    return ContainerServiceOrchestratorTypes.DCOS;
                case "DockerCE":
                    return ContainerServiceOrchestratorTypes.DockerCE;
                case "Custom":
                    return ContainerServiceOrchestratorTypes.Custom;
            }
            return null;
        }
    }
}