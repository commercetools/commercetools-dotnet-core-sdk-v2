using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class GoogleCloudPubSubDestination : IGoogleCloudPubSubDestination
    {
        public string Type { get; set; }

        public string ProjectId { get; set; }

        public string Topic { get; set; }
        public GoogleCloudPubSubDestination()
        {
            this.Type = "GoogleCloudPubSub";
        }
    }
}
