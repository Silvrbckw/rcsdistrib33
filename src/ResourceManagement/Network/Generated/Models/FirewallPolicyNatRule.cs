// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Firewall Policy NAT Rule.
    /// </summary>
    public partial class FirewallPolicyNatRule : FirewallPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyNatRule class.
        /// </summary>
        public FirewallPolicyNatRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyNatRule class.
        /// </summary>
        /// <param name="name">The name of the rule.</param>
        /// <param name="priority">Priority of the Firewall Policy Rule
        /// resource.</param>
        /// <param name="action">The action type of a Nat rule.</param>
        /// <param name="translatedAddress">The translated address for this NAT
        /// rule.</param>
        /// <param name="translatedPort">The translated port for this NAT
        /// rule.</param>
        /// <param name="ruleCondition">The match conditions for incoming
        /// traffic.</param>
        public FirewallPolicyNatRule(string name = default(string), int? priority = default(int?), FirewallPolicyNatRuleAction action = default(FirewallPolicyNatRuleAction), string translatedAddress = default(string), string translatedPort = default(string), FirewallPolicyRuleCondition ruleCondition = default(FirewallPolicyRuleCondition))
            : base(name, priority)
        {
            Action = action;
            TranslatedAddress = translatedAddress;
            TranslatedPort = translatedPort;
            RuleCondition = ruleCondition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the action type of a Nat rule.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public FirewallPolicyNatRuleAction Action { get; set; }

        /// <summary>
        /// Gets or sets the translated address for this NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "translatedAddress")]
        public string TranslatedAddress { get; set; }

        /// <summary>
        /// Gets or sets the translated port for this NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "translatedPort")]
        public string TranslatedPort { get; set; }

        /// <summary>
        /// Gets or sets the match conditions for incoming traffic.
        /// </summary>
        [JsonProperty(PropertyName = "ruleCondition")]
        public FirewallPolicyRuleCondition RuleCondition { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
