using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("GoogleCloudPubSub")]
    public partial class GoogleCloudPubSubDestination : Destination
    {
        public string ProjectId { get; set;}
        
        public string Topic { get; set;}
        public GoogleCloudPubSubDestination()
        { 
           this.Type = "GoogleCloudPubSub";
        }
    }
}
