// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Event Subscription
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EventSubscription : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EventSubscription class.
        /// </summary>
        public EventSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSubscription class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the resource</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        /// <param name="topic">Name of the topic of the event
        /// subscription.</param>
        /// <param name="provisioningState">Provisioning state of the event
        /// subscription. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="destination">Information about the destination where
        /// events have to be delivered for the event subscription.</param>
        /// <param name="filter">Information about the filter for the event
        /// subscription.</param>
        /// <param name="labels">List of user defined labels.</param>
        public EventSubscription(string id = default(string), string name = default(string), string type = default(string), string topic = default(string), string provisioningState = default(string), EventSubscriptionDestination destination = default(EventSubscriptionDestination), EventSubscriptionFilter filter = default(EventSubscriptionFilter), IList<string> labels = default(IList<string>))
            : base(id, name, type)
        {
            Topic = topic;
            ProvisioningState = provisioningState;
            Destination = destination;
            Filter = filter;
            Labels = labels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the topic of the event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.topic")]
        public string Topic { get; private set; }

        /// <summary>
        /// Gets provisioning state of the event subscription. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets information about the destination where events have to
        /// be delivered for the event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination")]
        public EventSubscriptionDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets information about the filter for the event
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filter")]
        public EventSubscriptionFilter Filter { get; set; }

        /// <summary>
        /// Gets or sets list of user defined labels.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labels")]
        public IList<string> Labels { get; set; }

    }
}
