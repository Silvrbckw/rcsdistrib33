// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Deployment properties with additional details.
    /// </summary>
    public partial class DeploymentPropertiesExtended
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        public DeploymentPropertiesExtended()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        /// <param name="provisioningState">Denotes the state of provisioning.
        /// Possible values include: 'NotSpecified', 'Accepted', 'Running',
        /// 'Ready', 'Creating', 'Created', 'Deleting', 'Deleted', 'Canceled',
        /// 'Failed', 'Succeeded', 'Updating'</param>
        /// <param name="correlationId">The correlation ID of the
        /// deployment.</param>
        /// <param name="timestamp">The timestamp of the template
        /// deployment.</param>
        /// <param name="duration">The duration of the template
        /// deployment.</param>
        /// <param name="outputs">Key/value pairs that represent deployment
        /// output.</param>
        /// <param name="providers">The list of resource providers needed for
        /// the deployment.</param>
        /// <param name="dependencies">The list of deployment
        /// dependencies.</param>
        /// <param name="templateLink">The URI referencing the
        /// template.</param>
        /// <param name="parameters">Deployment parameters. </param>
        /// <param name="parametersLink">The URI referencing the parameters.
        /// </param>
        /// <param name="mode">The deployment mode. Possible values are
        /// Incremental and Complete. Possible values include: 'Incremental',
        /// 'Complete'</param>
        /// <param name="debugSetting">The debug setting of the
        /// deployment.</param>
        /// <param name="onErrorDeployment">The deployment on error
        /// behavior.</param>
        /// <param name="templateHash">The hash produced for the
        /// template.</param>
        /// <param name="outputResources">Array of provisioned
        /// resources.</param>
        /// <param name="validatedResources">Array of validated
        /// resources.</param>
        /// <param name="error">The deployment error.</param>
        public DeploymentPropertiesExtended(ProvisioningState provisioningState = default(ProvisioningState), string correlationId = default(string), System.DateTime? timestamp = default(System.DateTime?), string duration = default(string), object outputs = default(object), IList<ProviderInner> providers = default(IList<ProviderInner>), IList<Dependency> dependencies = default(IList<Dependency>), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DeploymentMode? mode = default(DeploymentMode?), DebugSetting debugSetting = default(DebugSetting), OnErrorDeploymentExtended onErrorDeployment = default(OnErrorDeploymentExtended), string templateHash = default(string), IList<ResourceReference> outputResources = default(IList<ResourceReference>), IList<ResourceReference> validatedResources = default(IList<ResourceReference>), ErrorResponse error = default(ErrorResponse))
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Duration = duration;
            Outputs = outputs;
            Providers = providers;
            Dependencies = dependencies;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
            OnErrorDeployment = onErrorDeployment;
            TemplateHash = templateHash;
            OutputResources = outputResources;
            ValidatedResources = validatedResources;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets denotes the state of provisioning. Possible values include:
        /// 'NotSpecified', 'Accepted', 'Running', 'Ready', 'Creating',
        /// 'Created', 'Deleting', 'Deleted', 'Canceled', 'Failed',
        /// 'Succeeded', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the correlation ID of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Gets the timestamp of the template deployment.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets the duration of the template deployment.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; private set; }

        /// <summary>
        /// Gets key/value pairs that represent deployment output.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public object Outputs { get; private set; }

        /// <summary>
        /// Gets the list of resource providers needed for the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<ProviderInner> Providers { get; private set; }

        /// <summary>
        /// Gets the list of deployment dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "dependencies")]
        public IList<Dependency> Dependencies { get; private set; }

        /// <summary>
        /// Gets the URI referencing the template.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; private set; }

        /// <summary>
        /// Gets deployment parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; private set; }

        /// <summary>
        /// Gets the URI referencing the parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; private set; }

        /// <summary>
        /// Gets the deployment mode. Possible values are Incremental and
        /// Complete. Possible values include: 'Incremental', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeploymentMode? Mode { get; private set; }

        /// <summary>
        /// Gets the debug setting of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; private set; }

        /// <summary>
        /// Gets the deployment on error behavior.
        /// </summary>
        [JsonProperty(PropertyName = "onErrorDeployment")]
        public OnErrorDeploymentExtended OnErrorDeployment { get; private set; }

        /// <summary>
        /// Gets the hash produced for the template.
        /// </summary>
        [JsonProperty(PropertyName = "templateHash")]
        public string TemplateHash { get; private set; }

        /// <summary>
        /// Gets array of provisioned resources.
        /// </summary>
        [JsonProperty(PropertyName = "outputResources")]
        public IList<ResourceReference> OutputResources { get; private set; }

        /// <summary>
        /// Gets array of validated resources.
        /// </summary>
        [JsonProperty(PropertyName = "validatedResources")]
        public IList<ResourceReference> ValidatedResources { get; private set; }

        /// <summary>
        /// Gets the deployment error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ParametersLink != null)
            {
                ParametersLink.Validate();
            }
        }
    }
}
